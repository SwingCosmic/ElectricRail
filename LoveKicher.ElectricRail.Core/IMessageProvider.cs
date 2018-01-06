using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace LoveKicher.ElectricRail.Core
{
    /// <summary>
    /// 表示消息提供方必须要实现的接口
    /// </summary>
    /// <typeparam name="T">提供的消息类型</typeparam>
    public interface IMessageProvider<T>
    {
        event EventHandler<MessageEventArgs<T>> MessageReceived;

        void StartProcessing();
    }



}
