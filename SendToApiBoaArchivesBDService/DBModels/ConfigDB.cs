using Oracle.ManagedDataAccess.Client;
using SendToApiBoaArchivesBDService.DBModels;
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
        public static IDbConnection GetConnectionDB(string typeDB)
        {
            string strCon;
            switch (typeDB)
            {
                case TypesDB.ORACLE:
                    strCon = ConfigToOracleDBEnum.USER + "/" + ConfigToOracleDBEnum.PASSWORD + "@//" + ConfigToOracleDBEnum.DBSERVERHOST + "/" + ConfigToOracleDBEnum.SERVICENAME;
                    OracleConnection conn = new OracleConnection(strCon);
                    return conn;
                default:
                    return null;
            }


        }

    }
}
