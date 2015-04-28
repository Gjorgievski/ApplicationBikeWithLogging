using ApplicationBike.Common.Interfaces;
using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBike.Common.Loggers
{
    /// <summary>
    /// Class for Log4net logger
    /// </summary>
    internal class LoggerLog4Net : ILogger
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LoggerLog4Net()
        {
            //BasicConfigurator.Configure();
            XmlConfigurator.Configure(new System.IO.FileInfo("~/App.config"));
        }

        public void LogDebug(string message)
        {
            log.Debug(message);

        }

        public void LogInfo(string message)
        {
            log.Info(message);
        }

        public void LogWarn(string message)
        {
            log.Warn(message);
        }

        public void LogError(string message)
        {
            log.Error(message);
        }

        public void LogFatal(string message)
        {
            log.Fatal(message);
        }
    }
}
