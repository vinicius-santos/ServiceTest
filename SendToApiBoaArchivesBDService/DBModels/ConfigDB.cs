using Oracle.ManagedDataAccess.Client;
using SendToApiBoaArchivesBDService.DBModels.DBConfigurations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SendToApiBoaArchivesBDService.DBModels
{

    /*
     * Retorna uma connection de acordo com o tipo de banco recebido por parametro.
     */
    public class ConfigDB
    {
        private readonly string ORACLE = "Oracle";
        private readonly string SQL_SERVER = "Sql_Server";


        public IDbConnection OpenDB(string typeDB)
        {
            string strCon;
            switch (typeDB)
            {
                case "Oracle":
                    strCon = ConfigToOracleDBEnum.USER + "/" + ConfigToOracleDBEnum.PASSWORD + "@//" + ConfigToOracleDBEnum.DBSERVERHOST + "/" + ConfigToOracleDBEnum.SERVICENAME;
                    OracleConnection conn = new OracleConnection(strCon);
                    conn.Open();
                    return conn;
                default:
                    return null;
            }


        }

    }
}
