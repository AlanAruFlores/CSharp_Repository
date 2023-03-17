using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
namespace DataLayer
{
    public class VentasDAO
    {
        DataAcces db;
        MySqlCommand command;
        MySqlDataReader reader;

        public VentasDAO()
        {
            db = new DataAcces();
            command = new MySqlCommand();
        }

        public bool insertNewVenta(int iu, int ip)
        {
            bool value = false;

            MySqlParameter[] parameters = new MySqlParameter[2];
            parameters[0] = new MySqlParameter("iu", MySqlDbType.Int32);
            parameters[0].Value = iu;
            parameters[1] = new MySqlParameter("ip", MySqlDbType.Int32);
            parameters[1].Value = ip;

            command.Connection = db.OpenConnection();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "insert_venta";
            command.Parameters.AddRange(parameters);

            value = ((command.ExecuteNonQuery()) > 0) ? true : false;

            command.Parameters.Clear();
            db.CloseConnection();
            return value;
        }

        public string ShowAll()
        {
            command.Connection = db.OpenConnection();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "show_ventas";
            reader = command.ExecuteReader();

            string line = "";

            while (reader.Read())
            {
                line += "Usuario: " + reader.GetString("username") + " | Telefono:" + reader.GetInt32("usertelephone")
                    + "Producto: " + reader.GetString("productname")
                    + "Precio: $" + reader.GetInt32("productprice") +"\n";
            }

            db.CloseConnection();
            return line;
        }
        public List<Venta> getVentasAll()
        {

            List<Venta> ventas = new List<Venta>();
            command.Connection = db.OpenConnection();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "show_ventas";
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                User user = new User();
                user.UserName = reader.GetString("username");
                user.Telephone = reader.GetInt32("usertelephone");
                Product product = new Product();
                product.Name = reader.GetString("productname");
                product.Price = reader.GetDouble("productprice");
                ventas.Add(new Venta(user, product));

            }
            db.CloseConnection();
            return ventas;
        } 

    }
}
