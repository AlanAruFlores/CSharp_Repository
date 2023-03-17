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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaDAO personadao = new PersonaDAO();
                int idEliminar = int.Parse(txtId.Text);
                personadao.deleteRow(new Persona(idEliminar));
            }catch(Exception ex)
            {
                MessageBox.Show("Error: verifique que los datos esten correctos");
            }
        }
    }
}
