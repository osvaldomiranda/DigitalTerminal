using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace Modelo
{
    public class ConstribuyenteModel
    {
        public String rut { get; set; }
        public String rznSoc { get; set; }
        public String giro { get; set; }

        public ConstribuyenteModel()
        {
        }

        public ConstribuyenteModel(String rut, String rznSoc, String giro)
        {
            this.rut = rut;
            this.rznSoc = rznSoc;
            this.giro = giro;
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
                select.CommandText = "SELECT * FROM contribuyente "
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

        public void save(ConstribuyenteModel cm)
        {
            BaseDato con = new BaseDato();
            OdbcConnection conexion = con.ConnectPostgres();

            OdbcCommand select = new OdbcCommand();
            select.Connection = conexion;
            select.CommandText = "INSERT INTO contribuyente("
                                +"rut,"
                                +"\"rznSoc\","
                                +"giro) VALUES ('"
                                + cm.rut+"','"
                                + cm.rznSoc+"','"
                                + cm.giro+"');";
            OdbcDataReader reader = select.ExecuteReader();
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
                select.CommandText = "SELECT \"rutRecep\",\"rznSocRecep\",\"giroRecep\" FROM contribuyente where \"rznSocRecep\" LIKE '%" + nombre + "%'";
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
