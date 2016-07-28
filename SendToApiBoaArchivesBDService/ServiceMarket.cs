using SendToApiBoaArchivesBDService.DBModels;
using SendToApiBoaArchivesBDService.Import;
using SendToApiBoaArchivesBDService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace SendToApiBoaArchivesBDService
{
    public partial class ServiceMarket : ServiceBase
    {
        public ServiceMarket()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            System.Diagnostics.Debugger.Launch();
        }

        protected override void OnStop()
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
