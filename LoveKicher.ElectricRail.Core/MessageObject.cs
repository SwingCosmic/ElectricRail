using LoveKicher.ElectricRail.Core.Serialization;
using LoveKicher.ElectricRail.Core.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoveKicher.ElectricRail.Core
{
    /// <summary>
    /// 储存消息对象
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MessageObject<T>
    {
        /// <summary>
        /// 用指定的消息来源，来源类型和数据包装器初始化<see cref="MessageObject{T}"/>类的新实例。
        /// </summary>
        /// <param name="source">消息源</param>
        /// <param name="sourceType">消息来源类型</param>
        /// <param name="message">消息数据的包装器</param>
        public MessageObject(object source, string sourceType, DataWrapper<T> message)
        {
            Source = source;
            SourceType = sourceType;
            Content = message;
        }

        /// <summary>
        /// 用指定的消息来源和原始数据初始化<see cref="MessageObject{T}"/>类的新实例。
        /// </summary>
        /// <param name="source">消息源</param>
        /// <param name="message">消息数据</param>
        /// <remarks>
        /// <see cref="SourceType"/>属性默认会赋值为<paramref name="message"/>的类型名，
        /// 所使用的包装器为<see cref="RawDataWrapper{T}"/>
        /// </remarks>
        public MessageObject(object source, T message)
        {
            Source = source;
            SourceType = typeof(T).Name;
            Content = new RawDataWrapper<T>(message);
        }

        /// <summary>消息源</summary>
        public object Source { get; }

        /// <summary>消息来源的类型</summary>
        public string SourceType { get; }

        /// <summary>消息内容</summary>
        public DataWrapper<T> Content { get; set; }
    }
}
