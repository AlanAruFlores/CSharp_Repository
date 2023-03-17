using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargar_registroGenero();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            llenarTabla(txtBusqqueda.Text);
        }
        private void llenarTabla(String busqueda)
        {
            controlPersona ctrlPersona = new controlPersona();
            List<Persona> personas = new List<Persona>();
            personas = ctrlPersona.obtenerPersonas(busqueda);
            tablaGrid.DataSource = personas;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool verificacion = false;
            controlPersona controller = new controlPersona();
            if (txtId.Text != "")
            {
                verificacion = controller.updateRow(new Persona(int.Parse(txtId.Text),txtNombre.Text,int.Parse(txtEdad.Text),int.Parse(cbGenero.SelectedValue.ToString())));
            }
            else
            {
                verificacion = controller.insertRow(new Persona(txtNombre.Text, int.Parse(txtEdad.Text),int.Parse(cbGenero.SelectedValue.ToString())));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtId.Text = tablaGrid.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = tablaGrid.CurrentRow.Cells[1].Value.ToString();
            txtEdad.Text = tablaGrid.CurrentRow.Cells[2].Value.ToString();
            cbGenero.SelectedValue = tablaGrid.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            controlPersona controller = new controlPersona();

            DialogResult resultado = MessageBox.Show("¿Deseas eliminar este registro?", "Salir", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(tablaGrid.CurrentRow.Cells[0].Value.ToString());
                string nombre = tablaGrid.CurrentRow.Cells[1].Value.ToString();
                int edad = int.Parse(tablaGrid.CurrentRow.Cells[2].Value.ToString());
                int id_genero = int.Parse(tablaGrid.CurrentRow.Cells[3].Value.ToString());
                controller.deleteRow(new Persona(id, nombre, edad,id_genero));
            }
        }
        private void cargar_registroGenero()
        {
            controllerGenero controller = new controllerGenero();
            controller.cargarGeneros(cbGenero);
        }
    }
}
