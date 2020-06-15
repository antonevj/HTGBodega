using HTGBodega.Contrac;
using HTGBodega.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTGBodega.data
{
    public class DProveedor : IProveedor


    {


        public EProveedor Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EProveedor> GetAll(bool status)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "usp_Proveedor_getAll";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Estado", status);
                cmd.Connection = cnx;
                cnx.Open();

                var reader = cmd.ExecuteReader();

                var lista = new List<EProveedor>();
                while (reader.Read())
                {

                    lista.Add(new EProveedor
                    {

                        ID = Convert.ToInt32(reader["ID"]),
                        Razon_social = (reader["RazonSocial"].ToString()),
                        RUC = (reader["Ruc"].ToString()),
                        Direccion = (reader["Direccion"].ToString()),
                        Telefono = (reader["Telefono"].ToString()),
                        Mail = (reader["Mail"].ToString()),
                        //  Estado = Convert.ToBoolean(reader["Estado"]),


                    });

                }


                return lista;
            }
        }


        public int Create(EProveedor t)
        {

            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "usp_Proveedor_ICreate";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RazonSocial", t.Razon_social);
                cmd.Parameters.AddWithValue("@RUC", t.RUC);
                cmd.Parameters.AddWithValue("@Direccion", t.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", t.Telefono);
                cmd.Parameters.AddWithValue("@Mail", t.Mail);
                cmd.Parameters.AddWithValue("@Estado", t.Estado);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }

        }

     
       

        public int Update(EProveedor t)
        {

            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "usp_Proveedor_IUpdate";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", t.ID);
                cmd.Parameters.AddWithValue("@RazonSocial", t.Razon_social);
                cmd.Parameters.AddWithValue("@RUC", t.RUC);
                cmd.Parameters.AddWithValue("@Direccion", t.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", t.Telefono);
                cmd.Parameters.AddWithValue("@Mail", t.Mail);
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
                cmd.CommandText = "usp_Proveedor_IDelete";
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
