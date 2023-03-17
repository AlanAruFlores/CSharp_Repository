using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace LayerModel
{
   public class BD_Data
    {

        private static string stringConnection = "datasource=127.0.0.1; port = 3306;" +
            "username=root; password=; database=crud_usuarios";
        private static MySqlConnection connection;
        public static MySqlConnection OpenConnection()
        {
            if (connection == null)
            {
                connection =  new MySqlConnection(stringConnection);
                Console.WriteLine("Base de datos conectada");
                connection.Open();
            }

            if (connection.State == ConnectionState.Closed)
            {
                Console.WriteLine("Base de datos conectada");
                connection.Open();
            }
            return connection;
        }


        public static MySqlConnection CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                Console.WriteLine("Base de datos desconectada");
                connection.Close();
            }
            return connection;
        }




    }
}
