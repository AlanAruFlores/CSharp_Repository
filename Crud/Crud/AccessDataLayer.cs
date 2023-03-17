using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Crud
{
    class AccessDataLayer
    {+
        private static string DB_SERVIDOR = "localhost";
        private static string DB_USER = "root";
        private static string DB_PASSWORD = "pachan242";

        public static MySqlConnection conexion()
        {
            return new MySqlConnection("Database=crud_personas; Data Source=" + DB_SERVIDOR + "; User Id=" + DB_USER + "; Password=" + DB_PASSWORD + "");
        }
        public static void closeConnection(MySqlConnection conn)
        {
            conn.Close();
        }
    }
}
