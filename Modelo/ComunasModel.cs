using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
   public class ComunasModel
    {
        public int codCiudad { get; set; }
        public String nomCiudad { get; set; }
        public int codPais { get; set; }

        public ComunasModel()
        {
        }

        public void save(Int32 codCiudad, String nomComuna)
        {

            try
            {
            BaseDato con = new BaseDato();
            OdbcConnection conexion = con.ConnectPostgres();

            OdbcCommand select = new OdbcCommand();
            select.Connection = conexion;
            select.CommandText = "INSERT INTO comunas("
                                 +"\"nomComuna\","
                                 + "\"codCiudad\")"
                                 +" VALUES ('"+nomComuna+"',"+codCiudad+");";
            OdbcDataReader reader = select.ExecuteReader();


                        }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }


        }

        public DataTable getComunas()
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM comunas ";
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

        public DataTable getComunasXNombre(String nomComuna)
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM comunas where \"nomComuna\" Like '%" + nomComuna + "%'";
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
        
        public void updateComunas(Int32 codComuna,String nomComuna, Int32 codCiudad)
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "UPDATE comunas "
                    + "SET \"codCiudad\"='" + codCiudad + "',"
                    + "\"nomComuna\"='"+ nomComuna+"'"
                    + "WHERE \"codComuna\" = "+codComuna+";";
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

        public void delete(Int32 codComuna)
        {
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "DELETE FROM comunas "
                                     +" WHERE \"codCiudad\" = "+codComuna+";";
                OdbcDataReader reader = select.ExecuteReader();


            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }


    }
}
