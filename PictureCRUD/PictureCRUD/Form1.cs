using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventanaArchivos = new OpenFileDialog();
            ventanaArchivos.Filter = "Images|*.jpg;*.png";
            ventanaArchivos.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ventanaArchivos.Title = "Seleccione una imagen";

            if (ventanaArchivos.ShowDialog() == DialogResult.OK)
            {
                pictureImage.Image = Image.FromFile(ventanaArchivos.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ControllerUsuario controlador = new ControllerUsuario();
            if (txtId.Text == "")
            {
                MemoryStream memoria = new MemoryStream();
                pictureImage.Image.Save(memoria, ImageFormat.Jpeg);
                byte[] aBytes = memoria.ToArray();
                mostrarBytes(aBytes);
                string nombre = txtName.Text;
                controlador.insertNewUser(new Usuario(nombre, aBytes));
            }
            else
            {
                MemoryStream memory = new MemoryStream();
                pictureImage.Image.Save(memory, ImageFormat.Jpeg);
                byte[] aBytes = memory.ToArray();
                controlador.updateUser(new Usuario(int.Parse(txtId.Text), txtName.Text, aBytes));
            }
        }
        private void mostrarBytes(byte[] array)
        {
            string texto = "";
            for (int i = 0; i<array.Length; i++)
            {
                texto+=array[i]+" ";
            }
            MessageBox.Show(texto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                ControllerUsuario controller = new ControllerUsuario();
                int id = int.Parse(txtId.Text);
                Usuario checkUser = controller.getUser(new Usuario(id));

                if(checkUser != null)
                {
                    txtId.Text = checkUser.Id.ToString();
                    txtName.Text = checkUser.Nombre;
                    MemoryStream memory = new MemoryStream(checkUser.Imagen);
                    Bitmap map = new Bitmap(memory);
                    pictureImage.Image = map;
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar al usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            pictureImage.Image = null;
        }
    }
}
