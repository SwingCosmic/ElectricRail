using System;
using System.Collections.Generic;
using System.Text;

using LoveKicher.ElectricRail.Core.Utility;


namespace LoveKicher.ElectricRail.Core
{
    /// <summary>
    /// 表示包含消息事件数据的类
    /// </summary>
    /// <typeparam name="T">消息数据的类型</typeparam>
    public class MessageEventArgs<T> : EventArgs
    {
        public MessageObject<T> Message { get; set; }
    }

   
}