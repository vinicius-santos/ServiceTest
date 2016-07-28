using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SendToApiBoaArchivesBDService.DBModels
{
    /*
     Classe destinada a inseriri tipos de buscas que os mercados desejam:
     Ex: buscar apenas ofertas, buscar apenas produtos, etc...
     */

    public static class TypeSearchMarket
    {
        public const string ONLY_OFFERS = "Only_Offers";//Apenas ofertas
        public const string ONLY_PRODUCTS = "Only_Products";//Apenas produtos
        public const string PRODUCTS_AND_OFFERS = "Products_And_Offers";//Apenas produtos
    }
}
