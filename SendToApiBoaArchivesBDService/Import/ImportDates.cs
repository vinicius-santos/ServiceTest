using SendToApiBoaArchivesBDService.DBModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SendToApiBoaArchivesBDService.Import
{
    /*
     * Classe responsável por importar os dados dos bancos de dados, verifica qual tipo de banco vai acessar para construir as queries e retornar os dados, ainda verifica que tipo de busca deve fazer
     * Ex: apenas produtos ou produtos e ofertas etc, pode ser configurável de acordo com o mercado
     * Basta apenas inserir esse valor de busca na Classe TypeSearchMarket e criar uma querye para esta opção.
     */
    public class ImportDates
    {
        public static void importValuesDB(IDbConnection conn, string typeDB)
        {
            switch (typeDB)
            {
                case TypesDB.ORACLE:
                    GetOracleData(conn);
                    break;
                default:
                    break;

            }
        }

        public static void GetOracleData(IDbConnection conn)
        {


        }
    }
}
