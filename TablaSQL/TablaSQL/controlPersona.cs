using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace TablaSQL
{
    class controlPersona : Conexion // herencia
    {
        public List<Persona> obtenerPersonas(string busqueda)
        {
            List<Persona> listaPersonas = new List<Persona>();
            try
            {
                MySqlConnection conexion = getConnection();
                conexion.Open();
                MySqlDataReader lector = null;

                MySqlCommand comando = null;

                if (busqueda == null)
                    comando = new MySqlCommand("SELECT id,nombre,edad,genero_id FROM personas", conexion);
                else               
                    comando = new MySqlCommand("SELECT id,nombre,edad,genero_id FROM personas WHERE id LIKE '%" + busqueda + "%' OR nombre LIKE '%" + busqueda + "%' " +
                        "OR edad LIKE '%" + busqueda + "%'",conexion);
                

                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        listaPersonas.Add(new Persona(lector.GetInt32(0), lector.GetString(1), lector.GetInt32(2), lector.GetInt32(3)));
                    }
                }
                else
                    MessageBox.Show("NO SE ENCONTRO RESULTADOS");

                closeConnection(conexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return listaPersonas;
        }
        public bool insertRow(Persona persona)
        {
            bool verificar = false;
            try
            {
                MySqlConnection conn = getConnection();
                conn.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO personas(nombre,edad,genero_id) VALUES('" + persona.Nombre + "', " + persona.Edad + ", "+persona.IdGenero+")", conn);
                int registroAfectados = comando.ExecuteNonQuery();

                if (registroAfectados > 0)
                    verificar = true;

                closeConnection(conn);
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return verificar;
        }
        public bool updateRow(Persona persona)
        {
            bool verificar = false;
            try
            {
                MySqlConnection conn = getConnection();
                conn.Open();
                MySqlCommand comando = new MySqlCommand("UPDATE personas SET nombre = '" + persona.Nombre + "', edad = " + persona.Edad + ", genero_id ="+persona.IdGenero+" WHERE id = "+persona.Id+"",conn);
                int registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados > 0)
                    verificar = true;

                closeConnection(conn);
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return verificar;
        }
        public bool deleteRow(Persona persona)
        {
            bool verificar = false;
            try
            {
                MySqlConnection conn = getConnection();
                conn.Open();
                MySqlCommand comando = new MySqlCommand("DELETE FROM personas WHERE id= " + persona.Id + " AND nombre = '" + persona.Nombre + "' AND edad =" + persona.Edad+" AND genero_id="+persona.IdGenero, conn);
                int registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados > 0)
                    verificar = true;
                closeConnection(conn);
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return verificar;
        }
    }
}
