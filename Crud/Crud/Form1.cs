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
    public partial class Form1 : Form
    {
        static Form2 ventanaRegistro;
        static Form3 ventanaEliminar;
        static Form4 ventanaActualizar;
        public Form1()
        {
            InitializeComponent();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultado = "No se encontro a ninguna persona";
            PersonaDAO personadao = new PersonaDAO();
            List<Persona> listaPersonas = personadao.getlistaPersonas();

            if (listaPersonas.Count > 0)
            {
                resultado = "";
                foreach(Persona persona in listaPersonas)
                {
                    resultado += persona.ToString()+"\n";
                }
            }
            MessageBox.Show(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventanaRegistro = new Form2();
            ventanaRegistro.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ventanaEliminar = new Form3();
            ventanaEliminar.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ventanaActualizar = new Form4();
            ventanaActualizar.Show();
        }
    }
}
