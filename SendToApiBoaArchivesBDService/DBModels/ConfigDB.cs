using Oracle.ManagedDataAccess.Client;
using SendToApiBoaArchivesBDService.DBModels.DBConfigurations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SendToApiBoaArchivesBDService.DBModels
{

    public class ConfigDB
    {
        public void ConfigAccessDB()
        {
            string strPass;
            //string strCon = "USER_NAME/PASSWORD@//DB_SERVER_HOST_OR_IP:PORT/SERVICE_NAME";
            string strCon = ConfigToOracleDBEnum.USER + "/" + ConfigToOracleDBEnum.PASSWORD + "@//" + ConfigToOracleDBEnum.DBSERVERHOST + "/" + ConfigToOracleDBEnum.SERVICENAME;
            using (OracleConnection conn = new OracleConnection(strCon))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM emp_table WHERE username = :userId";
                    cmd.CommandType = CommandType.Text;
                    OracleParameter pUser = new OracleParameter();
                    pUser.OracleDbType = OracleDbType.Varchar2;
                    pUser.Value = "xyz";
                    cmd.Parameters.Add(pUser);
                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        dr.Read();
                        //strPass = dr["pwd"].ToString();
                        //strPass = dr.GetOracleString(1)); // Assuming that the pwd is a second column.
                    }
                }
            }
        }

    }
}
