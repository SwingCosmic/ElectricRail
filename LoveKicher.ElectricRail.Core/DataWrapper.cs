using System;
using System.Collections.Generic;
using System.Text;

namespace LoveKicher.ElectricRail.Core
{
    /// <summary>
    /// 表示一个数据包装器，以便于储存和传递数据
    /// </summary>
    /// <typeparam name="T">要包装的数据类型</typeparam>
    public abstract class DataWrapper<T> : IDataWrapper<T, object>
    {
        /// <summary>获取被包装的数据</summary>
        public object WrappedData { get; protected set; }

        /// <summary>获取包装器的类型名称</summary>
        public abstract string WrapperType { get; }

        /// <summary>
        /// 包装<typeparamref name="T"/>类型的数据
        /// </summary>
        /// <param name="data">要包装的数据对象</param>
        public abstract void Wrap(T data);

        /// <summary>
        /// 解包已包装的数据
        /// </summary>
        /// <returns>解包后的数据</returns>
        public abstract T Unwarp();

    }
}
