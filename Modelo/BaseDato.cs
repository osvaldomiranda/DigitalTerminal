using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;


namespace Modelo
{
    class BaseDato
    {
                    
                    public OdbcConnection ConnectPostgres()
                    {

                        String stringConn = "Driver={PostgreSQL UNICODE};Server=localhost;Port=5432;Database=digitalterminal;Uid=postgres;Pwd=SOPABRU2011;";
                        OdbcConnection conn = new OdbcConnection(stringConn);
                        try
                        {
                            conn.Open();
                        }
                        catch (OdbcException ex)
                        {
                            Console.WriteLine("Problemas al conectar a la base datos", "Error de Conexion");
                            Console.WriteLine(ex.Message + "\n\n" + "*********************StackTrace: \n\n" + ex.StackTrace);
                            //Environment.Exit(0);
                            return null;

                        }
                        return conn;
                    }
    }
}
