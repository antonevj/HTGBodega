using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTGBodega.Contrac.Base
{
   public interface IRead<T,Y> where T : class
    {
        //obtener todo  los registros  de la base de datos 

        IEnumerable<T> GetAll();

        //obtener un registro especifico

        T Get(Y id);
    }

}
