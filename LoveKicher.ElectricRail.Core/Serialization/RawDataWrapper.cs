using System;
using System.Collections.Generic;
using System.Text;

namespace LoveKicher.ElectricRail.Core.Serialization
{
    /// <summary>
    /// 表示一个不做任何操作的数据包装器
    /// </summary>
    public sealed class RawDataWrapper<T> : DataWrapper<T>
    {
        public RawDataWrapper()
        { }

        public RawDataWrapper(T data)
        {
            WrappedData = data;
        }
        public override string WrapperType => "Raw Data";

        public override T Unwarp()
        {
            return (T)WrappedData;
        }

        public override void Wrap(T  data)
        {
            WrappedData = data;
        }
    }
}
