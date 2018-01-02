using System;
using System.Collections.Generic;
using System.Text;

namespace LoveKicher.ElectricRail.Core.Logging
{
    /// <summary>
    /// 记录运行日志
    /// </summary>
    public sealed class Logger
    {
        private ILogProvider _provider;

        internal static Logger _instance;

        public Logger(ILogProvider provider)
        {
            if (_instance == null)
                _instance = this;
            _provider = provider;
        }

        public  bool AddLog<T>(LogLevel level, T logInfo, object source, IDataFormartter<T, string> formartter = null)
        {
            return _provider.Log(level, logInfo, source, formartter);
        }
    }
}
