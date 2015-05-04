using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace DigitalTerminal
{
    class Connect
    {
        public OdbcConnection getConnect()
        {

            String stringConn = "Driver={PostgreSQL UNICODE};Server=localhost;Port=5432;Database=digitalterminal;Uid=postgres;Pwd=preciosodt3;";
            OdbcConnection conn = new OdbcConnection(stringConn);
            try
            {
                conn.Open();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Problemas al conectar a la base datos", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message + "\n\n" + "*********************StackTrace: \n\n" + ex.StackTrace);
                Environment.Exit(0);
                return null;

            }
            return conn;
        }
    }
}
