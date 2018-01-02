using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using System.Text.RegularExpressions;
using LoveKicher.ElectricRail.Core.Extensions;

namespace LoveKicher.ElectricRail.Core.Utility
{
    /// <summary>
    /// 表示一个以JSON字符串储存的对象
    /// </summary>
    /// <typeparam name="T">对象的.NET类型</typeparam>
    public class JsonObject<T>
    {

        private T _value;

        /// <summary>
        /// 获取被包装对象的<see cref="Type"/> 对象
        /// </summary>
        public Type WrappedType => typeof(T);

        /// <summary>
        /// 获取或设置对象的.NET值
        /// </summary>
        public T ManagedValue
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// 获取或设置对象的JSON值
        /// </summary>
        public string JsonValue
        {
            get => JsonConvert.SerializeObject(_value);
            set
            {
                try
                {
                    //如果是个“空”对象（不包括空数组），赋默认值(null)
                    if (value.IsMatch(@"^\s*{\s*}\s*$", out Match m))
                        _value = default(T);
                    else
                        _value = JsonConvert.DeserializeObject<T>(value);
                }
                catch (JsonException ex)
                {
                    throw new ArgumentException("无效的JSON字符串", ex);
                }
                catch(Exception)
                { throw; }
 
            }
        }


        public static JsonObject<T> FromJsonString(string json)
        {
            var o = new JsonObject<T>();
            o.JsonValue = json;
            return o;
        }
    }
}
