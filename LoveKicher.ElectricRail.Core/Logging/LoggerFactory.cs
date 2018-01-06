using LoveKicher.ElectricRail.Core.Logging.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoveKicher.ElectricRail.Core.Logging
{
    public sealed class LoggerFactory
    {
        public static Logger CreateLogger(string type)
        {
            switch (type.ToLower())
            {
                case "stdout":
                case "console":
                    var p = new ConsoleLogProvider();
                    var logger = new Logger(p);
                    return logger;
                default:
                    throw new ArgumentException("无法识别的logger类型。", nameof(type));
            }
        }
    }
}
