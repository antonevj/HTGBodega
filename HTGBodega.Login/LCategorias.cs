using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTGBodega.Entity;

using HTGBodega.data;


namespace HTGBodega.Login
{
   public class LCategorias
    {

        public IEnumerable<ECategorias> GetAll(bool status)
        {


            return new DCategorias().GetAll(status);
        }

        //llamar de DCategorias
        public int Create(ECategorias t)
        {
            return new DCategorias().Create(t);
        }

















    }
   
   
}
