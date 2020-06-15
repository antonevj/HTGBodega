using HTGBodega.Contrac.Base;
using HTGBodega.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTGBodega.Contrac
{
  public  interface IProveedor :IRead<EProveedor>, ICreate<EProveedor>, IUpdate<EProveedor>, IDelete<EProveedor>
    {
    }
}
