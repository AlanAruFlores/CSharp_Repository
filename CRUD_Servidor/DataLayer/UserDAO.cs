using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
namespace DataLayer
{
    public class UserDAO
    {

        private DataAcces db;
        private MySqlCommand com;
        private MySqlDataReader reader;

        public UserDAO() {
            db = new DataAcces();
            com = new MySqlCommand();
        }

        public void RegisterNewAccount(string username, string pass, int telephone)
        {
            MySqlParameter[] parameters = new MySqlParameter[3];
            parameters[0] = new MySqlParameter("n",MySqlDbType.VarChar);
            parameters[0].Value = username;
            parameters[1] = new MySqlParameter("p", MySqlDbType.VarChar);
            parameters[1].Value = pass;
            parameters[2] = new MySqlParameter("t", MySqlDbType.Int32);
            parameters[2].Value = telephone;


            com.Connection = db.OpenConnection();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "register";
            com.Parameters.AddRange(parameters);
            com.ExecuteNonQuery();

            com.Parameters.Clear();
            db.CloseConnection();
        }
        public User LoginAccount(string username, string password)
        {
            User user = null;
            MySqlParameter[] parameters = new MySqlParameter[2];
            parameters[0] = new MySqlParameter("n", MySqlDbType.VarChar);
            parameters[0].Value = username;
            parameters[1] = new MySqlParameter("p", MySqlDbType.VarChar);
            parameters[1].Value = password;

            com.Connection = db.OpenConnection();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "login";
            com.Parameters.AddRange(parameters);

            reader = com.ExecuteReader();

            while(reader.Read())
            {
                user = new User(reader.GetInt32("id"), reader.GetString("name"),
                    reader.GetString("password"), reader.GetInt32("telephone"));
            }

            com.Parameters.Clear();
            db.CloseConnection();
            return user;
        }
    }
}
