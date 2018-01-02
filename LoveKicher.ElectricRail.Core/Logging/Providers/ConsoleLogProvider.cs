using System;
using System.Collections.Generic;
using System.Text;

namespace LoveKicher.ElectricRail.Core.Logging.Providers
{
    public class ConsoleLogProvider : ILogProvider
    {
        public ConsoleColor TimeForegroundColor { get; set; } 
            = ConsoleColor.Yellow;
                                                 
        public ConsoleColor PromptForegroundColor { get; set; } 
            = ConsoleColor.Green;
                                                
        public ConsoleColor SourceForegroundColor { get; set; } 
            = ConsoleColor.Magenta;


        public const ConsoleColor TraceContentColor = ConsoleColor.Gray;
        public const ConsoleColor DebugContentColor = ConsoleColor.Gray;
        public const ConsoleColor InfoContentColor = ConsoleColor.White;
        public const ConsoleColor WarningContentColor = ConsoleColor.Yellow;
        public const ConsoleColor ErrorContentColor = ConsoleColor.Red;
        public const ConsoleColor FatalContentColor = ConsoleColor.DarkRed;
       
        public bool IsEnabled { get; set; } = true;

        public bool Log<T>(LogLevel level, T logInfo, object source, IDataFormartter<T, string> formartter = null)
        {
            if (IsEnabled)
            {
                try
                {
                    var c = Console.ForegroundColor;

                    Console.ForegroundColor = TimeForegroundColor;
                    Console.Write($"[{DateTime.Now}] ");
                    Console.ForegroundColor = PromptForegroundColor;
                    Console.Write("Received from ");
                    Console.ForegroundColor = SourceForegroundColor;
                    Console.WriteLine($"[{source}]:");
                    Console.ForegroundColor = ((Func<LogLevel, ConsoleColor>)(l =>
                    {
                        switch (l)
                        {
                            case LogLevel.Trace:
                                return TraceContentColor;
                            case LogLevel.Debug:
                                return DebugContentColor;
                            case LogLevel.Info:
                                return InfoContentColor;
                            case LogLevel.Warning:
                                return WarningContentColor;
                            case LogLevel.Error:
                                return ErrorContentColor;
                            case LogLevel.Fatal:
                                return FatalContentColor;
                            default:
                                return InfoContentColor;
                        }
                    }))(level);
                    Console.WriteLine(logInfo);

                    Console.ForegroundColor = c;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        public bool Log<T>(LogLevel level, T logInfo, object source, Func<T, string> formartter)
        {
            throw new NotImplementedException();
        }
    }
}
