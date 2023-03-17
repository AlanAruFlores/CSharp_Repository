using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    class PersonaDAO
    {
        private static string DB_SELECT = "SELECT id,nombre,edad FROM personas";
        private static string DB_INSERT = "INSERT INTO personas(nombre,edad) VALUES";
        private static string DB_DELETE = "DELETE FROM personas WHERE id=";
        private static string DB_UPDATE = "UPDATE personas SET";
        public List<Persona> getlistaPersonas()
        {
            List<Persona> lista = new List<Persona>();
            try
            {
                MySqlConnection conn = AccessDataLayer.conexion();
                conn.Open();
                MessageBox.Show("Conexion Exitosa");

                MySqlDataReader lector = null;
                MySqlCommand comando = new MySqlCommand(DB_SELECT, conn);
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Persona(lector.GetInt32(0), lector.GetString(1), lector.GetInt32(2)));
                }
                AccessDataLayer.closeConnection(conn);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return lista;
        }
        public void insertPerson(Persona personaNueva)
        {
            try
            {
                MySqlConnection conn = AccessDataLayer.conexion();
                conn.Open();
                MessageBox.Show("Conexion Exitosa");
                MySqlCommand comando = new MySqlCommand(DB_INSERT+"('"+personaNueva.Nombre+"',"+personaNueva.Edad+")", conn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se registro el usuario");
                AccessDataLayer.closeConnection(conn);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void deleteRow(Persona personaEliminar)
        {
            try
            {
                MySqlConnection conn = AccessDataLayer.conexion();
                conn.Open();
                MySqlCommand comando = new MySqlCommand(DB_DELETE + "" + personaEliminar.Id, conn);
                int registroAfectados = comando.ExecuteNonQuery();
                if (registroAfectados > 0)
                {
                    MessageBox.Show("Se elimino al usuario");
                }
                else
                {
                    MessageBox.Show("No se elimino al usuario debido a que no se lo pudo localizar");
                }
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void updateRow(Persona personaActualizada)
        {
            try
            {
                MySqlConnection conn = AccessDataLayer.conexion();
                MySqlCommand comando = new MySqlCommand(DB_UPDATE+" nombre='"+personaActualizada.Nombre+"',edad="+personaActualizada.Edad+" WHERE id="+personaActualizada.Id, conn);
                int registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados > 0)
                {
                    MessageBox.Show("Se pudo actualizar el registro");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro");
                }
                AccessDataLayer.closeConnection(conn);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
