using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaSQL
{
    class Conexion
    {
        private static string servidor = "localhost";
        private static string user = "root";
        private static string password = "pachan242";

        protected  MySqlConnection getConnection()
        {
            return new MySqlConnection("Database= crud_personas; Data Source=" + servidor + "; User Id=" + user + "; Password=" + password+"");
        }

        protected void closeConnection(MySqlConnection conn)
        {
            conn.Clone();
        }
    }
}
