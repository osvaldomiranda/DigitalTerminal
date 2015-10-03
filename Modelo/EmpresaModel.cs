using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace Modelo
{
   public class EmpresaModel
    {
        public string Rut { get; set; }
        public string RazonSocial { get; set; }
        public string GiroEmisor { get; set; }
        public Int32 CodigoSiiSucursal { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Int32 Acteco { get; set; }
        public string DireccionOrigen { get; set; }
        public string ComunaOrigen { get; set; }
        public string CiudadOrigen { get; set; }

        public EmpresaModel getEmpresa()
        {
            
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "SELECT * FROM empresa ";
                OdbcDataReader reader = select.ExecuteReader();
                while(reader.Read())
                {
                    this.Rut = reader.GetString(reader.GetOrdinal("rutempresa"));
                    this.RazonSocial = reader.GetString(reader.GetOrdinal("razonsocial"));
                    this.GiroEmisor = reader.GetString(reader.GetOrdinal("giroemisor"));
                    this.CodigoSiiSucursal = reader.GetInt32(reader.GetOrdinal("codigosiisucursal"));
                    this.Telefono = reader.GetString(reader.GetOrdinal("telefonoemis"));
                    this.Correo = reader.GetString(reader.GetOrdinal("correoemis"));
                    this.Acteco = reader.GetInt32(reader.GetOrdinal("acteco"));
                    this.DireccionOrigen = reader.GetString(reader.GetOrdinal("direccionorigen"));
                    this.ComunaOrigen = reader.GetString(reader.GetOrdinal("comunaorigen"));
                    this.CiudadOrigen = reader.GetString(reader.GetOrdinal("ciudadorigen"));
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

            return this;
        }



        
    }
}
