using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
namespace LayerModel
{
    public class UsuarioDAO
    {
        private MySqlDataReader reader;
        private MySqlCommand command;
        

        public UsuarioDAO()
        {
            this.command = new MySqlCommand();
        }
        public List<Usuario> getAll()
        {
            List<Usuario> list = new List<Usuario>();

            command.Connection = BD_Data.OpenConnection();
            command.CommandText = "proc_select_all";
            command.CommandType = CommandType.StoredProcedure;

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Usuario(
                    reader.GetInt32("id"),
                    reader.GetString("username"),
                    reader.GetString("email"),
                    reader.GetInt32("age")
                ));
            }
            BD_Data.CloseConnection();
            return list;
        }
        public Usuario getUsuario(int id) {
            Usuario usuario = null;
            command.Connection = BD_Data.OpenConnection();
            command.CommandText = "proc_select";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("id_usuario", id);
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                usuario = new Usuario(
                    reader.GetInt32("id"),
                    reader.GetString("username"),
                    reader.GetString("email"),
                    reader.GetInt32("age")
                );
            }
            command.Parameters.Clear();
            BD_Data.CloseConnection();
            return usuario;
        }
        public void saveUsuario(Usuario sendUsuario)
        {
            MySqlParameter[] collection = new MySqlParameter[3];
            collection[0] = new MySqlParameter("name", MySqlDbType.VarChar);
            collection[0].Value = sendUsuario.UserName;
            collection[1] = new MySqlParameter("mail", MySqlDbType.VarChar);
            collection[1].Value = sendUsuario.Email;
            collection[2] = new MySqlParameter("years", MySqlDbType.Int32);
            collection[2].Value = sendUsuario.Edad;

            command.Connection = BD_Data.OpenConnection();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "procedureinsert";
            command.Parameters.AddRange(collection);
            //command.Parameters.AddWithValue("name", sendUsuario.UserName);
            //command.Parameters.AddWithValue("mail", sendUsuario.Email);
            //command.Parameters.AddWithValue("years", sendUsuario.Edad);
            int rows = command.ExecuteNonQuery();
            
            if (rows <= 0) Console.WriteLine("Consulta no hecha");
            else Console.WriteLine("Consulta hecha con exito");
            command.Parameters.Clear();
            BD_Data.CloseConnection();
        }

        public void editUsuario(Usuario usuarioEdit)
        {
            command.Connection = BD_Data.OpenConnection();
            command.CommandText = "proc_update";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("name", usuarioEdit.UserName);
            command.Parameters.AddWithValue("mail", usuarioEdit.Email);
            command.Parameters.AddWithValue("years", usuarioEdit.Edad);
            command.Parameters.AddWithValue("id_usuario", usuarioEdit.Id);

            int rows = command.ExecuteNonQuery();
            if (rows <= 0) Console.WriteLine("Consulta no hecha");
            else Console.WriteLine("Consulta hecha con exito");

            command.Parameters.Clear();
            BD_Data.CloseConnection();
        }

        public void deleteUsuario(int idDelete)
        {
            command.Connection = BD_Data.OpenConnection();
            command.CommandText = "proc_delete";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("id_usuario", idDelete);

            int rows = command.ExecuteNonQuery();
            if (rows <= 0) Console.WriteLine("Consulta no hecha");
            else Console.WriteLine("Consulta hecha con exito");

            command.Parameters.Clear();
            BD_Data.CloseConnection();
        }
    }
}
