using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
namespace DataLayer
{
    public class ProductDAO
    {
        DataAcces db;
        MySqlCommand command;
        MySqlDataReader reader;

        public ProductDAO()
        {
            this.db = new DataAcces();
            command = new MySqlCommand();
        }

        public List<Product> ShowProducts()
        {
            List<Product> list = new List<Product>();
            command.Connection = db.OpenConnection();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "show_products";

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Product(reader.GetInt32("id"),
                    reader.GetString("name"),
                    reader.GetDouble("price")));
            }
        
            db.CloseConnection();
            return list;
        }

        public Product SelectProduct(int id)
        {

            Product product = null;
            command.Connection = db.OpenConnection();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "select_product";
            command.Parameters.AddWithValue("i",id);

            reader = command.ExecuteReader();
            if (reader.Read())
                product = new Product(reader.GetInt32("id"),
                    reader.GetString("name"),
                    reader.GetDouble("price"));


            command.Parameters.Clear();
            db.CloseConnection();
            return product;
            
        }

    }
}
