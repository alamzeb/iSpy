using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace iSpy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if DEBUG
            iSpyDetector objDetector = new iSpyDetector();
            objDetector.onDebug();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);

#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new iSpyDetector() 
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }
}
