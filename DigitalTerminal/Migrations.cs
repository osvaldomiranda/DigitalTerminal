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
            createUser.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
