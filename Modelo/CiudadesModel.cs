using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
   public class CiudadesModel
    {
        public int codCiudad { get; set; }
        public String nomCiudad { get; set; }
        public int codPais { get; set; }

        public CiudadesModel()
        {
        }

        public void save(Int32 codPais, String nomCiudad)
        {

            try
            {
            BaseDato con = new BaseDato();
            OdbcConnection conexion = con.ConnectPostgres();

            OdbcCommand select = new OdbcCommand();
            select.Connection = conexion;
            select.CommandText = "INSERT INTO ciudades("
                                 +"\"nomCiudad\","
                                 + "\"codPais\")"
                                 +"VALUES ('"+nomCiudad+"',"+codPais+");";
            OdbcDataReader reader = select.ExecuteReader();


                        }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }


        }

        public DataTable getCiudades()
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM ciudades ";
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

        public DataTable getCiudadXNombre(String nomCiudad)
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM ciudades where \"nomCiudad\" Like '%" + nomCiudad + "%'";
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
        
        public void updateCiudad(Int32 codPais,String nomCiudad, Int32 codCiudad)
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "UPDATE ciudades "
                    + "SET \"codPais\"='" + codPais + "',"
                    + "\"nomCiudad\"='"+ nomCiudad+"'"
                    + "WHERE \"codCiudad\" = "+codCiudad+";";
                OdbcDataReader reader = select.ExecuteReader();
                datatable.Load(reader);

            }
            catch (Exception ex)
            {

                throw new Exception("Error" + ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

        }

        public void delete(Int32 codCiudad)
        {
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "DELETE FROM ciudades "
                                     +" WHERE \"codCiudad\" = "+codCiudad+";";
                OdbcDataReader reader = select.ExecuteReader();


            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }


    }
}
