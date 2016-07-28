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
            string configRun = TimeVerify.verifyRunTask(task);
            if (!String.IsNullOrEmpty(configRun))
            {
                var TypeDB = configRun.Split(':')[0];
                var TypeSearch = configRun.Split(':')[1];
                IDbConnection conn = ConfigDB.GetConnectionDB(TypeDB);
                ImportDates.importValuesDB(conn, TypeDB, TypeSearch);

            }
        }
    }
}
