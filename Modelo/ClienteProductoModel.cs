using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace Modelo
{
   public class ClienteProductoModel
    {
       public Int32 idProducto {get; set;}
       public string rutCliente { get; set; }
       public decimal precioNeto { get; set; }
       public decimal precioVenta { get; set; }

       public DataTable getProdClient(string rut)
       {
           DataTable datatable = new DataTable();
           SqlConnection sqlcon = new SqlConnection();
           try
           {
               BaseDato con = new BaseDato();
               OdbcConnection conexion = con.ConnectPostgres();

               OdbcCommand select = new OdbcCommand();
               select.Connection = conexion;
               select.CommandText = "select producto.\"id\",producto.nombre,producto.\"codigoInt\", "
                                    + "clienteproducto.\"precioNeto\",clienteproducto.\"precioVenta\", "
                                    + "producto.codimpuesto,producto.exento "
                                    + "from   clienteproducto,producto,cliente "
                                    + "where  clienteproducto.\"idProducto\" = producto.\"id\" "
                                    + "and    clienteproducto.\"rutCliente\" = cliente.\"rutRecep\" "
                                    + "and    clienteproducto.\"rutCliente\" = '" + rut + "'";
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

        public DataTable getProdClientXCod(string rut, string codProd)
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "select producto.\"id\",producto.nombre,producto.\"codigoInt\", "
			                         +"clienteproducto.\"precioNeto\",clienteproducto.\"precioVenta\", "
			                         +"producto.codimpuesto,producto.exento "
                                     +"from   clienteproducto,producto,cliente "
                                     +"where  clienteproducto.\"idProducto\" = producto.\"id\" "
                                     +"and    clienteproducto.\"rutCliente\" = cliente.\"rutRecep\" "
                                     +"and    clienteproducto.\"rutCliente\" = '" + rut + "'"
                                     +"and    producto.\"codigoInt\" = '" +codProd+"'" ;
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

        public DataTable getProdClientXNom(string rut, string nomProd)
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "select producto.\"id\",producto.nombre,producto.\"codigoInt\", "
                                     + "clienteproducto.\"precioNeto\",clienteproducto.\"precioVenta\", "
                                     + "producto.codimpuesto,producto.exento "
                                     + "from   clienteproducto,producto,cliente "
                                     + "where  clienteproducto.\"idProducto\" = producto.\"id\" "
                                     + "and    clienteproducto.\"rutCliente\" = cliente.\"rutRecep\" "
                                     + "and    clienteproducto.\"rutCliente\" = '" + rut + "'"
                                     + "and    producto.\"nombre\" LIKE '%" + nomProd + "%'";
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

        public void save(ClienteProductoModel cliProdModel)
        {

            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText =
                    "INSERT INTO clienteproducto("
                    +"\"idProducto\", \"rutCliente\", \"precioNeto\", \"precioVenta\")"
                    +" VALUES ("
                    + cliProdModel.idProducto + ",'"
                    + cliProdModel.rutCliente + "',"
                    + cliProdModel.precioNeto +","
                    + cliProdModel.precioVenta +");";
                  
                OdbcDataReader reader = select.ExecuteReader();


            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }

        }

        public string searchProdxCliente(Int32 codProd, string rutCliente)
        {
            string respuesta = "true";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                BaseDato con = new BaseDato();
                OdbcConnection conexion = con.ConnectPostgres();

                OdbcCommand select = new OdbcCommand();
                select.Connection = conexion;
                select.CommandText = "select * from clienteproducto "
                                    +"where \"idProducto\" = "+codProd+" and \"rutCliente\" = '"+rutCliente+"'";
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
