using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Login
{
    class ControllerUser
    {
        public void createUser(Usuario user)
        {
            string sql = "INSERT INTO usuarios (nombre,contraseña) VALUES (@nombre, @contraseña)";
            try
            {
                MySqlConnection conn = DataLayer.getConnection();
                conn.Open();
                MySqlCommand comando = new MySqlCommand(sql,conn);
                comando.Parameters.AddWithValue("nombre", user.Nombre);
                comando.Parameters.AddWithValue("contraseña", user.Contraseña);
                int rowsAffected = comando.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Mensaje: Registro Ingresado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mensaje: No se pudo registrar al usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                DataLayer.closeConnection(conn);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: Verifique la conexion con la base de datos u otras cosas relacionadas", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }catch(Exception ex)
            {
                MessageBox.Show("Error: Verifique bien los datos solicitados", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Usuario readUser(Usuario user)
        {
            Usuario getUser = null;
            string sql = "SELECT nombre, contraseña from usuarios WHERE nombre =@nombre AND contraseña =@contraseña";
            try
            {
                MySqlConnection conn = DataLayer.getConnection();
                conn.Open();
                MySqlCommand comando = new MySqlCommand(sql, conn);
                comando.Parameters.AddWithValue("nombre", user.Nombre);
                comando.Parameters.AddWithValue("contraseña", user.Contraseña);
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    getUser = new Usuario(lector.GetString(0),lector.GetString(1));
                }
                else
                {
                    MessageBox.Show("Mensaje: No se encontro al usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                DataLayer.closeConnection(conn);
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return getUser;
        }
        public void insertCoin (Usuario usuario)
        {
            string sql = "UPDATE usuarios SET coins = coins + @cont WHERE id = @id";
            try
            {
                MySqlConnection conn = DataLayer.getConnection();
                conn.Open();
                MySqlCommand comando = new MySqlCommand(sql, conn);
                comando.Parameters.AddWithValue("cont", usuario.Coin);
                comando.Parameters.AddWithValue("id", usuario.Id);
                bool isOk = (comando.ExecuteNonQuery() > 0) ? true : false;
                if (isOk)
                {
                    MessageBox.Show("Mensaje: Se realizo con exito la transaccion", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mensaje: No se realizo la transaccion", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                DataLayer.closeConnection(conn);
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
