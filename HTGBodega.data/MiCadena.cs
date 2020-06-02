using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;



namespace HTGBodega.data
{
   public class MiCadena
    {
        public static string CadenaCnx()
        {

            return ConfigurationManager.ConnectionStrings["micadena"].ConnectionString;

        }
    }
}
