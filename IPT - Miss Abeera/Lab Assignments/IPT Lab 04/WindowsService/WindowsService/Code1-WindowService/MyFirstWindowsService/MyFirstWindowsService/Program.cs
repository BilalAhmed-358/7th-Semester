using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Text;

namespace MyFirstWindowsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new TestService()
            };
            ServiceBase.Run(ServicesToRun);

        }
    }
}
