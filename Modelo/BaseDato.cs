using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data.SQLite;


namespace Modelo
{
    class BaseDato
    {
        public SQLiteConnection ConnectSqlite()
        {
            String strConn = @"Data Source=C:/DigitalTerminal/configDT.sqlite;Pooling=true;FailIfMissing=false;Version=3";
            SQLiteConnection myConn = new SQLiteConnection(strConn);
            try
            {
                myConn.Open();
            }
            catch (SQLiteException exSqlite)
            {
                Console.WriteLine("Problemas al conectar a la base datos", "Error de Sqlite");
                Console.WriteLine(exSqlite.Message + "\n\n" + "*********************StackTrace: \n\n" + exSqlite.StackTrace);
                //Environment.Exit(0);
                return null;
            }
            return myConn;
        }

        private string stringConn()
        {
            string stringcon = string.Empty;
            SQLiteConnection sqliteConn = new SQLiteConnection();
            sqliteConn = this.ConnectSqlite();

            string sql = "SELECT * FROM basedato";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               stringcon = "Driver={PostgreSQL UNICODE};Server=" + reader["server"].ToString()
                                   + ";Port=" + reader["port"].ToString()
                                   + ";Database=" + reader["database"].ToString()
                                   + ";Uid=" + reader["user"].ToString()
                                   + ";Pwd=" + reader["pass"].ToString() + ";";
            }

            return stringcon;
        }

        public OdbcConnection ConnectPostgres()
        {

            String stringConn = this.stringConn();
            OdbcConnection conn = new OdbcConnection(stringConn);
            try
            {
                conn.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Problemas al conectar a la base datos", "Error de Postgres");
                Console.WriteLine(ex.Message + "\n\n" + "*********************StackTrace: \n\n" + ex.StackTrace);
                //Environment.Exit(0);
                return null;

            }
            return conn;
        }


    }


}
