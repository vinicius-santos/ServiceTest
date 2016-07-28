using SendToApiBoaArchivesBDService.DBModels;
using SendToApiBoaArchivesBDService.Import;
using SendToApiBoaArchivesBDService.Models;
using System;
using System.Collections.Generic;
using System.Data;
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


            //Only for test my friends......

            string task = @"../../DBModels/JsonsConfig/Markets/BoaConfig.json";
            string RunInDB = TimeVerify.verifyRunTask(task);
            if (!String.IsNullOrEmpty(RunInDB))
            {
                IDbConnection conn =  ConfigDB.GetConnectionDB(RunInDB);
                ImportDates.importValuesDB(conn, RunInDB);
            }
        }
    }
}
