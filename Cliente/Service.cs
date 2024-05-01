using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cliente
{
    public class Servico
    {
        public Servico()
        {

        }

        public static string UrlBaseFoodService()
        {
            string urlBase = "http://localhost:5003/api";
            return urlBase;
        }
    }

}
