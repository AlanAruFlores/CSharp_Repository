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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);

                PersonaDAO personaDao = new PersonaDAO();
                personaDao.insertPerson(new Persona(name, age));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: Verifique los datos");
            }

        }
    }
}
