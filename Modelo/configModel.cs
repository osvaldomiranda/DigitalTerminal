using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace Modelo
{
   public  class ConfigModel
    {
        public string clienteProducto { get; set; }

        public ConfigModel getConfig()
        {
            string stringcon = string.Empty;
            SQLiteConnection sqliteConn = new SQLiteConnection();
            sqliteConn = new BaseDato().ConnectSqlite();

            string sql = "SELECT * FROM config";
            SQLiteCommand command = new SQLiteCommand(sql, sqliteConn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.clienteProducto = reader["clienteproducto"].ToString();
                    
            }

            return this; 
        }
    }
}
