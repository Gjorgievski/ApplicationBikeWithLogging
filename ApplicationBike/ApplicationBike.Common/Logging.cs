using ApplicationBike.Common.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBike.Common
{
    /// <summary>
    /// Logging class
    /// </summary>
    public class Logging
    {

        private ILogger log = null;

        [Inject]
        public ILogger Log { set { log = value; } }

        public void LogDebug(string message)
        {
            log.LogDebug(message);
        }

        public void LogInfo(string message)
        {
            log.LogInfo(message);
        }

        public void LogWarn(string message)
        {
            log.LogWarn(message);
        }

        public void LogError(string message)
        {
            log.LogError(message);
        }

        public void LogFatal(string message)
        {
            log.LogFatal(message);
        }

    }
}
