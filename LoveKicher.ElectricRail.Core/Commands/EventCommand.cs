using System;
using System.Collections.Generic;
using System.Text;

namespace LoveKicher.ElectricRail.Core.Commands
{
    public abstract class EventCommand : ICommand
    {
        public CommandState State { get; set; } = CommandState.Uninitialized;

        public abstract string Name { get; }

        public event EventHandler<ExecuteEventArgs> Execute;

        public void RunCommand(object target, params object[] parameters)
        {
            OnExecute(new ExecuteEventArgs(this)
            {
                Parameters = parameters,
                CommandTarget = target 
            });
        }

        protected virtual void OnExecute(ExecuteEventArgs e)
        {
            Execute?.Invoke(this, e);
        }
    }
}
