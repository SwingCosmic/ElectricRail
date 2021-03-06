﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoveKicher.ElectricRail.Core.Logging
{
    public interface  ILogProvider
    {
        bool IsEnabled { get; set; }
        bool Log<T>(LogLevel level, T logInfo, object source, IDataFormartter<T, string> formartter = null);

        bool Log<T>(LogLevel level, T logInfo, object source, Func<T,string> formartter);
    }
}
