using SendToApiBoaArchivesBDService.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace SendToApiBoaArchivesBDService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new ServiceMarket()
            //};
            //ServiceBase.Run(ServicesToRun);

            string task = @"../../DBModels/JsonsConfig/Markets/BoaConfig.json";
            bool run = TimeVerify.verifyRunTask(task);
            if (run)
            {

            }
        }
    }
}
