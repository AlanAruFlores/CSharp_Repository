using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtName.Text;
                int edad = int.Parse(txtAge.Text);
                int id = int.Parse(txtId.Text);
                PersonaDAO personadao = new PersonaDAO();
                personadao.updateRow(new Persona(id,nombre, edad));
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
