using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTGBodega.Contrac.Base
{
    public interface IUpdate<T>where T:class
    {
        int Update(T t); 
    }
}
