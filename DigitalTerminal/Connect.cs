using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace DigitalTerminal
{
    class Connect
    {
        public OdbcConnection getConnect()
        {

            String stringConn = "Driver={PostgreSQL UNICODE};Server=127.0.0.1;Port=5432;Database=digitalterminal;Uid=postgres;Pwd=preciosodt3;";
            OdbcConnection conn = new OdbcConnection(stringConn);
            try
            {
                conn.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex.Message + "\n\n" + "*********************StackTrace: \n\n" + ex.StackTrace);
                return null;
            }
            return conn;
        }
    }
}
