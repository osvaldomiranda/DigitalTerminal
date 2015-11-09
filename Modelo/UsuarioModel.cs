using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace Modelo
{
  public   class UsuarioModel
    {

        public string validaUser(string usuario, string clave)
        {
            string respuesta = "true";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "select * from usuario "
                                    + "where \"usuario\" = '" + usuario + "' and \"password\" = '" + clave + "'";
                OdbcDataReader reader = select.ExecuteReader();
                if (reader.HasRows == false)
                {
                    respuesta = "false";
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }


            return respuesta;
        }
    }
}
