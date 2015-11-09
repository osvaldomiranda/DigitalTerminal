using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace Modelo
{
   public class TipoDteModel
    {
        public DataTable getTipoDte()
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM tipodte where tipo in('33','34','52','61','801','802','1000') order by nombre";
                OdbcDataReader reader = select.ExecuteReader();
                datatable.Load(reader);

            }
            catch (Exception ex)
            {
                datatable = null;
                throw new Exception("Error" + ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            return datatable;
        }

        public String getNombre(String codDte)
        {
            String nombre = String.Empty;
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM tipodte where tipo = '"+ codDte +"';";
                OdbcDataReader reader = select.ExecuteReader();
                while (reader.Read())
                {
                    nombre = reader.GetString(reader.GetOrdinal("nombre"));
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

            return nombre;
        }
    }
}
