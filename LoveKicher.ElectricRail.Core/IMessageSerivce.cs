using System;
using System.Collections.Generic;
using System.Text;

namespace LoveKicher.ElectricRail.Core
{
    public interface IMessageSerivce<T>
    {
        MessageObject<T> GetMessageResponse();
    }
}
