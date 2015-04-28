using ApplicationBike.Common.Interfaces;
using ApplicationBike.Common.Loggers;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBike.Common
{
    /// <summary>
    /// Class for making logging
    /// </summary>
    public class Log
    {

        public static Logging Instance
        {
            get
            {
                Ninject.IKernel kernal = new StandardKernel();

                kernal.Bind<ILogger>().To<LoggerLog4Net>();
                Logging instance = kernal.Get<Logging>();

                return instance;
            }
            private set
            {

            }
        }



    }
}
