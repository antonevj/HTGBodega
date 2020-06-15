using HTGBodega.data;
using HTGBodega.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTGBodega.Login
{
  public  class LProveedor
    {

        public IEnumerable<EProveedor> GetAll(bool status)
        {


            return new DProveedor().GetAll(status);
        }

        
        public int Create(EProveedor t)
        {
            return new DProveedor().Create(t);
        }

        public int Update(EProveedor t)
        {
            return new DProveedor().Update(t);
        }

        public int Delete(int id)
        {
            return new DProveedor().Delete(id);
        }

    }
}
