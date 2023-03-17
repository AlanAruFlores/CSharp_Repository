using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class DataLayer
    {
        private static string nameBd = "appLogin_bd";
        private static string server = "localhost";
        private static string user = "root";
        private static string password = "pachan242";

        public static MySqlConnection getConnection()
        {
            return new MySqlConnection("Database = " + nameBd + "; Server = " + server + "; User Id = " + user + "; Password=" + password);
        }
        public static void closeConnection(MySqlConnection conn)
        {
            conn.Close();
        }
    }
}
