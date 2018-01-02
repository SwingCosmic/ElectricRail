using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace LoveKicher.ElectricRail.Core.Serialization
{
    public class JsonWrapper<T> : DataWrapper<T>
    {
        public JsonWrapper()
        { }
        public JsonWrapper(T s)
        {
            Wrap(s);
        }

        public new string WrappedData { get; protected set; }

        public override string WrapperType => "JSON";

        public override T Unwarp()
        {
            return JsonConvert.DeserializeObject<T>(WrappedData);
        }

        public override void Wrap(T data)
        {
            WrappedData = JsonConvert.SerializeObject(data);
        }
    }
}
