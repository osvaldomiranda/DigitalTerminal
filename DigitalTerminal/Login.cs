using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace DigitalTerminal
{
    class Login
    {
        public bool isValid(String email, String password)
        {
            bool isValid = false;

            Connect con = new Connect();
            OdbcConnection conexion = con.getConnect();

            OdbcCommand select = new OdbcCommand();
            select.Connection = conexion;
            select.CommandText = "SELECT \"user\".email, \"user\".password FROM public.\"user\" WHERE \"user\".email = '"+email+"' AND \"user\".password = '"+password+"'" ;
            OdbcDataReader reader = select.ExecuteReader();
            if(reader.RecordsAffected >0){
                isValid = true;
            }
            conexion.Close();
            return isValid;
        }
    }
}
