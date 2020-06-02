using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTGBodega.Contrac.Base
{
   public interface ICrud<T> where T:class
    {
        //obtener todo  los registros  de la base de datos 

        IEnumerable<T> GetAll();
       
        //obtener un registro especifico

        T Get(int id);
        int Create(T t);
        int Update(T t);
        int Delete(T id);



    }
}
