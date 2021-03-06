﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTGBodega.Contrac.Base
{
   public interface IRead<T> where T : class
    {
        //obtener todo  los registros  de la base de datos 

        IEnumerable<T> GetAll(bool status);

        //obtener un registro especifico

        T Get(int id);

    }

}
