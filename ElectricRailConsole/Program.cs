using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoveKicher.ElectricRail.Core;
using LoveKicher.ElectricRail.Core.Serialization;
using LoveKicher.ElectricRail.Core.Logging;
using Autofac;
using LoveKicher.ElectricRail.Core.Logging.Providers;

namespace ElectricRailConsole
{
    class Program
    {


        class ConsoleMsgProvider : IMessageProvider<string>
        {
            public  event EventHandler<MessageEventArgs<string>> MessageReceived;

            public bool IsRunning = false;
            public  void StartProcessing()
            {
                IsRunning = true;

                while (IsRunning)
                {
                    var s = Console.ReadLine();
                    MessageReceived?.Invoke(this, new MessageEventArgs<string>
                    {
                        Message = new MessageObject<string>("Standard Input", s)
                    });
                }
                
            }
        }


       
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<IMessageProvider<string>>();
            builder.RegisterType<ConsoleMsgProvider>().As<IMessageProvider<string>>();

            builder.RegisterType<ILogProvider>();
            builder.RegisterType<ConsoleLogProvider>().As<ILogProvider>();
            builder.Register(c => LoggerFactory.CreateLogger("console")).As<ILogProvider>();
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var logger = scope.Resolve<ILogProvider>();
                var msgProvider = scope.Resolve<IMessageProvider<string>>();

                msgProvider.MessageReceived += (s, e) =>
                {
                    logger.Log(LogLevel.Info, e.Message.Content.Unwarp(), e.Message.Source);
                };

                msgProvider.StartProcessing();
            }
        }

        //var logger = LoggerFactory.CreateLogger("console");
        ////fake info
        //logger.AddLog(LogLevel.Warning, "破番茄", "http://localhost:12450/infotest");
        //var provider = new ConsoleMsgProvider();
        //provider.MessageReceived += (s, e) =>
        //{
        //    logger.AddLog(LogLevel.Info, e.Message.Content.Unwarp(), e.Message.Source);
        //};
        //provider.StartProcessing();


    }
}
