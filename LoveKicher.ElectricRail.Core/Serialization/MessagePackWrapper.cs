using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;
namespace LoveKicher.ElectricRail.Core.Serialization
{
    public class MessagePackWrapper<T> : DataWrapper<T>
    {
        public new byte[] WrappedData { get; set; }
        public override string WrapperType => "MessagePack";

        public override T Unwarp()
        {
            return MessagePackSerializer.Deserialize<T>(WrappedData);
        }

        public override void Wrap(T data)
        {
            WrappedData = MessagePackSerializer.Serialize(data);
        }
    }
}
