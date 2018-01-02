using LoveKicher.ElectricRail.Core.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoveKicher.ElectricRail.Core
{
    public class MessageObject<T>
    {
        public MessageObject(object source, string sourceType, DataWrapper<T> message)
        {
            Source = source;
            SourceType = sourceType;
            Content = message;
        }

        public object Source { get;}

        public string SourceType { get; }

        public DataWrapper<T> Content { get; set; }
    }
}
