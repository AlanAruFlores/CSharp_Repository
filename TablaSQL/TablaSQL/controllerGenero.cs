using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TablaSQL
{
    class controllerGenero : Conexion
    {
        public void cargarGeneros(ComboBox combobox)
        {
            string sql = "SELECT idGenero,nombre FROM generos";
            try
            {
                MySqlConnection conn = getConnection();
                conn.Open();
                MySqlCommand comando = new MySqlCommand(sql, conn);
                MySqlDataAdapter adaptardata = new MySqlDataAdapter(comando);
                DataTable tb = new DataTable();
                adaptardata.Fill(tb);
                combobox.ValueMember = "idGenero";
                combobox.DisplayMember = "nombre";
                combobox.DataSource = tb;
                closeConnection(conn);
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
