using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace Modelo
{
    public class ContribuyenteModel
    {
        public String rut { get; set; }
        public String rznSoc { get; set; }
        public String giro { get; set; }
        public String direccion { get; set;}
        public int codComuna { get; set; }
        public int codCiudad { get; set; }
        public string telefono { get; set; }

        public ContribuyenteModel()
        {
        }

        public ContribuyenteModel(String rut, String rznSoc, String giro)
        {
            this.rut = rut;
            this.rznSoc = rznSoc;
            this.giro = giro;
        }

        public OdbcDataReader getClienteReader(String rut)
        {
            SqlConnection sqlcon = new SqlConnection();
            OdbcDataReader reader;
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM cliente "
                                    + "INNER JOIN ciudades ON \"codCiudadRecep\" =\"codCiudad\" "
                                    + "INNER JOIN comunas ON \"codCmnaRecep\" = \"codComuna\" "
                                    + "where \"rutRecep\" = '" + rut + "'";
                 reader = select.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            return reader;
        }


        public DataTable getContribuyente(String rut)
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM cliente "
                                    + "INNER JOIN ciudades ON \"codCiudadRecep\" =\"codCiudad\" "
                                    + "INNER JOIN comunas ON \"codCmnaRecep\" = \"codComuna\" "
                                    + "where \"rutRecep\" = '" + rut + "'";
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

        public void save(ContribuyenteModel cm)
        {
           
            SqlConnection sqlcon = new SqlConnection();
            try
            {
            BaseDato con = new BaseDato();
            OdbcConnection conexion = con.ConnectPostgres();

            OdbcCommand select = new OdbcCommand();

            select.Connection = conexion;
            select.CommandText = "INSERT INTO cliente("
                                +"\"rutRecep\","
                                + "\"rznSocRecep\","
                                +"\"giroRecep\","
                                +"\"dirRecep\","
                                +"\"codCmnaRecep\","
                                +"\"codCiudadRecep\","
                                + "\"telefono\""
                                +") VALUES ('"
                                + cm.rut+"','"
                                + cm.rznSoc+"','"
                                + cm.giro + "','"
                                + cm.direccion + "',"
                                + cm.codComuna + ","
                                + cm.codCiudad + ",'"
                                + cm.telefono+"');";

             OdbcDataReader reader = select.ExecuteReader();

            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            
            finally
                        {
                            sqlcon.Close();
                        }


        }

        public DataTable getContribuyenteXNombre(String nombre)
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT \"rutRecep\",\"rznSocRecep\",\"giroRecep\" FROM cliente where \"rznSocRecep\" LIKE '%" + nombre + "%'";
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

    }
}
