using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBike.Common.Interfaces
{
    /// <summary>
    /// Interface for loggers
    /// </summary>
    public interface ILogger
    {
        void LogDebug(string message);

        void LogInfo(string message);

        void LogWarn(string message);

        void LogError(string message);

        void LogFatal(string message);

    }
}
