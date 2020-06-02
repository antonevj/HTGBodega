using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTGBodega.Contrac;
using HTGBodega.Entity;
using System.Data;
using System.Data.SqlClient;

namespace HTGBodega.data
{
    public class DCategorias : ICategorias
    {
        public ECategorias Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ECategorias> GetAll(bool status)
        {

            using (SqlConnection cnx=new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "usp_Categorias_getAll";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Estado", status);
                cmd.Connection = cnx;
                cnx.Open();

                var reader = cmd.ExecuteReader();

                var lista = new List<ECategorias>();
                while (reader.Read())
                {

                    lista.Add(new ECategorias
                    {

                        ID = Convert.ToInt32(reader["ID"]),
                        Nombre = (reader["Nombre"].ToString()),
                        Descripcion = (reader["Descripcion"].ToString()),
                      //  Estado = Convert.ToBoolean(reader["Estado"]),


                    }) ;
             
                }


                return lista;
            }
        }


    }
}
