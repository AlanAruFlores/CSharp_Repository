using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PictureCRUD
{
    class ControllerUsuario
    {

        public Usuario getUser(Usuario usuario)
        {
            Usuario checkUser = null;
            try
            {
                string sql = "SELECT id,nombre,imagen FROM usuarios WHERE id = " + usuario.Id;
                MySqlConnection conn = Conexion.getConexion();
                conn.Open();
                MySqlDataReader lector = null;
                MySqlCommand comando = new MySqlCommand(sql,conn);
                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    lector.Read();
                    checkUser = new Usuario(lector.GetInt32(0),lector.GetString(1),(byte[])lector["imagen"]);
                }
                conn.Close();
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return checkUser;
        }
        public void insertNewUser(Usuario usuario)
        {
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();
                string sql = "INSERT INTO usuarios (nombre,imagen) VALUES('" + usuario.Nombre + "',@imagen)";
                MySqlCommand comando = new MySqlCommand("INSERT INTO usuarios (nombre,imagen) VALUES('" + usuario.Nombre + "',@imagen)", conexion);
                comando.Parameters.AddWithValue("imagen", usuario.Imagen);
                comando.ExecuteNonQuery();
                MessageBox.Show("Ingresado con exito", "Mensaje", MessageBoxButtons.OK);
                Conexion.closeConnection(conexion);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Surgio un Error en la conexion", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void updateUser(Usuario usuario)
        {
            string sql = "UPDATE usuarios SET nombre = @nombre, imagen = @imagen WHERE id  = @id";
            try
            {
                MySqlConnection conn = Conexion.getConexion();
                conn.Open();
                MySqlCommand comando = new MySqlCommand(sql, conn);
                comando.Parameters.AddWithValue("nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("imagen", usuario.Imagen);
                comando.Parameters.AddWithValue("id", usuario.Id);
                int registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados > 0)
                {
                    MessageBox.Show("Se Actualizo el registro seleccionado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
