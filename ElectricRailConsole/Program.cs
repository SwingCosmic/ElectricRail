using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoveKicher.ElectricRail.Core;
using LoveKicher.ElectricRail.Core.Serialization;
using LoveKicher.ElectricRail.Core.Logging;

namespace ElectricRailConsole
{
    class Program
    {
        class ConsoleMsgProvider : IMessageProvider<string>
        {
            public event EventHandler<MessageEventArgs<string>> MessageReceived;

            public bool IsRunning = false;
            public  void StartProcessing()
            {
                IsRunning = true;

                while (IsRunning)
                {
                    var s = Console.ReadLine();
                    MessageReceived?.Invoke(this, new MessageEventArgs<string>
                    {
                        Message = new MessageObject<string>("Standard Input", "String", new RawDataWrapper<string>(s))
                    });
                }
                
            }
        }



        static void Main(string[] args)
        {
            var logger = LoggerFactory.CreateLogger("console");
            //fake info
            logger.AddLog(LogLevel.Warning, "破番茄", "http://localhost:12450/infotest");
            var provider = new ConsoleMsgProvider();
            provider.MessageReceived += (s, e) =>
            {
                logger.AddLog(LogLevel.Info, e.Message.Content.Unwarp(), e.Message.Source);
            };
            provider.StartProcessing();
        }


        
    }
}
