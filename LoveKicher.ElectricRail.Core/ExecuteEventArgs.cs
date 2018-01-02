using System;
using System.Collections.Generic;
using System.Text;

namespace LoveKicher.ElectricRail.Core
{

    public class ExecuteEventArgs : EventArgs
    {
        public ExecuteEventArgs(object source,object originData = null)
        {
            Source = source;
            OriginData = originData;
        }
        public object CommandTarget { get; set; }
        public object Source { get; }
        public object OriginData { get; }
        public object[] Parameters { get; set; }
    }
}
