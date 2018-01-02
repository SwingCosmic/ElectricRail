using System;
using System.Collections.Generic;
using System.Text;

namespace LoveKicher.ElectricRail.Core
{
    public interface ICommand
    {
        CommandState State { get; set; }

        event EventHandler<ExecuteEventArgs> Execute;
    }

    public enum CommandState
    {
        /// <summary>该命令未初始化，这是一个命令刚被创建时的默认状态</summary>
        Uninitialized = 0,
        /// <summary>正常状态，该命令可以被执行</summary>
        Normal,
        /// <summary>该命令即将被执行，此时可以阻止该命令</summary>
        PreviewExecute,
        /// <summary>该命令正在执行中</summary>
        Executing,
        /// <summary>该命令已经成功执行完毕</summary>
        Executed,
        /// <summary>该命令执行过程中发生异常</summary>
        OnError,
        /// <summary>该命令不可用，可能是因为相关的对象当前的状态不支持该命令</summary>
        Unavailable
    }

}

