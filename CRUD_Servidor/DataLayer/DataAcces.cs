using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
namespace DataLayer
{
    public class DataAcces
    {
        private MySqlConnection conn;
        public DataAcces()
        {
           this.conn = new MySqlConnection("datasource=localhost; port=3307; username=root; password=; database=db_tienda");
        }

        public MySqlConnection OpenConnection()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
