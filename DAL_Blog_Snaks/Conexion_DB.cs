using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL_Blog_Snaks
{
   public  class Conexion_DB
    {
        //Server=127.0.0.1;Uid=foo_dbo;Pwd=pass;Database=foo_db;
        //Data source=localhost; user=root; Database=blog_snaks; Pasword=''"
        private static string connet = @"Server=127.0.0.1; port=3306; Uid=local_Desktop;Pwd=;Database=blog_snaks;";
        public static MySqlConnection Conexion_Mysql()
        {
            return  new MySqlConnection(connet);
        }
        public static MySqlCommand Get_Comando(string pComando, MySqlConnection pConexion)
        {
            return new MySqlCommand(pComando, pConexion as MySqlConnection);
        }
    }
}
