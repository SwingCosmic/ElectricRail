using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace LoveKicher.ElectricRail.Core.Serialization
{
    public class XmlWrapper<T> : DataWrapper<T>
    {
        public new string WrappedData { get; set; }

        private static XmlSerializer serializer = new XmlSerializer(typeof(T));
        public override string WrapperType => "XML";

        public override T Unwarp()
        {
            using (var sr = new StringReader(WrappedData))
            {
                return (T)serializer.Deserialize(sr);
            }
            
        }

        public override void Wrap(T data)
        {
            using (var sr = new StringWriter())
            {
                serializer.Serialize(sr, data);
                WrappedData = sr.GetStringBuilder().ToString();
            }

        }
    }
}
