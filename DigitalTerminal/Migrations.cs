using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace DigitalTerminal
{
    class Migrations
    {
        public void migrate()
        {
            //**********************************************
            // Base de Datos
            string connStr = "Server=localhost;Port=5432;User Id=postgres;Password=enter;";

            OdbcConnection conDB = new OdbcConnection(connStr);
            OdbcCommand createDB = new OdbcCommand();
            createDB.Connection = conDB;
            createDB.CommandText = "CREATE DATABASE IF NOT EXIST digitalterminal"
                                    + "WITH OWNER = postgres"
                                    + "ENCODING = 'UTF8'"
                                    + "TABLESPACE = pg_default"
                                    + "CONNECTION LIMIT = -1;";

            try
            {
                conDB.Open();
                createDB.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex.Message + "\n\n" + "*********************StackTrace: \n\n" + ex.StackTrace);  
            }
            conDB.Close();


            //**********************************************
            // Tablas


            Connect con = new Connect();
            OdbcConnection conexion = con.getConnect();

            //**********************************************
            // USER
            OdbcCommand createUser = new OdbcCommand();
            createUser.Connection = conexion;
            createUser.CommandText = "CREATE TABLE IF NOT EXIST \"user\"" +
            "(" +
            "    email character varying(60) NOT NULL," +
            "    password character varying(12)," +
            "    CONSTRAINT email PRIMARY KEY (email)" +
            ")" +
            "WITH (" +
            "    OIDS=FALSE" +
            ");" +
            "ALTER TABLE \"user\"" +
            "OWNER TO postgres;";

            try
            {
                createUser.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex.Message + "\n\n" + "*********************StackTrace: \n\n" + ex.StackTrace);
            }
            conexion.Close();
        }
    }
}
