using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace Modelo
{
   public class folioModel
    {
       string estado { get; set; }

       public Int32 getUltimoFolio()
       {
           Int32 ultimoFolio = 0;
           SqlConnection sqlcon = new SqlConnection();
          try
          {
               BaseDato con = new BaseDato();
               OdbcConnection conexion = con.ConnectPostgres();
               OdbcCommand select = new OdbcCommand();
               select.Connection = conexion;
               select.CommandText = "select min(folio) from folio where estado = 'DISPONIBLE';";
               OdbcDataReader reader = select.ExecuteReader();
               while (reader.Read())
               {
                   ultimoFolio = Convert.ToInt32(reader.GetValue(0));
               }
               modificaEstado("OCUPADO", ultimoFolio);
           }
           catch (Exception ex)
           {
               throw new Exception("Error" + ex.Message);
           }
           finally
           {
               sqlcon.Close();
           }
           
           return ultimoFolio;
           //select min(folio) from folio where estado = 'DISPONIBLE'
           //cambiar a estado a ocupado
           // validar con try catch
       }

       public void modificaEstado(String estado, Int32 folio)
       {
           SqlConnection sqlcon = new SqlConnection();
           try{
           BaseDato con = new BaseDato();
           OdbcConnection conexion = con.ConnectPostgres();
           OdbcCommand select2 = new OdbcCommand();
           select2.Connection = conexion;
           select2.CommandText = "update folio  set estado = '"+estado+"' where folio = " + folio + ";";
           OdbcDataReader reader2 = select2.ExecuteReader();
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

    }
}
