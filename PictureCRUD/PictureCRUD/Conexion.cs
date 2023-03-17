using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureCRUD
{
    class Conexion
    {
        public static MySqlConnection getConexion() {
            return new MySqlConnection("Database=crud_usuarios; Data Source= 'localhost'; User Id = 'root'; Password = 'pachan242'");
        }
        public static void closeConnection(MySqlConnection connection)
        {
            connection.Close();
        }
    }
}
