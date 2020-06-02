using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTGBodega.Contrac.Base
{
   public interface IDelete<T> where T:class
    {
        int Delete(T id);

    }
}
