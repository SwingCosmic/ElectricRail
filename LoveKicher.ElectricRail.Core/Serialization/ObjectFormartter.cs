using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LoveKicher.ElectricRail.Core.Extensions;

namespace LoveKicher.ElectricRail.Core.Serialization
{
    public class ObjectFormartter : IDataFormartter<object, string>
    {
        public string FormartData(object source, params object[] parameters)
        {

            //if (source is string)
            //{
            //    return string.Format(source as string, parameters);
            //}
            //else
            var output = source.GetType().Name + " {";
            var t = source.GetType();
            var props = t.GetProperties();

            var propNames = parameters.Length > 0 ? parameters 
                : (from p in props select p.Name).ToArray();

            var items = new List<string>();
            foreach (var para in propNames)
            {
                if (props.Where(p => p.Name == para.ToString()).Count() > 0)
                {
                    var p = t.GetProperty(para as string);
                    var value = p.GetValue(source);

                    var item = p.Name + " = ";
                    
                    item += t.IsPrimitive ? value 
                        : value is string ? "\"" + value + "\"" 
                        : value is System.Collections.IEnumerable 
                        ? "[" + string.Join(", ", ((System.Collections.IEnumerable)value).
                            Select(i => FormartData(value))) + "]"
                        : FormartData(value);

                    items.Add(item);
                }
                
            }
            output += string.Join(", ", items);
            output += "}";

            return output;
        }

        

    }
   

}
