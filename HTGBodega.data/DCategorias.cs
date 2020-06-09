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
        public int Create(ECategorias t)
        {


            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "usp_Categoria_ICreate";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", t.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", t.Descripcion);
                cmd.Parameters.AddWithValue("@Estado",t.Estado);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }

        }

        public int Update(ECategorias t)
        {




            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "usp_Categoria_IUpdate";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", t.ID);
                cmd.Parameters.AddWithValue("@Nombre", t.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", t.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", t.Estado);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }




        }

        public int Delete(int id)
        {


            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "usp_Categoria_IDelete";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", id);
              
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }



        }


       
    }
}
