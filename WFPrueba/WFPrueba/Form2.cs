using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace WFPrueba
{
    public partial class Form2 : Form
    {
        static Form1 ventanaPrincipal = new Form1() ;
        string mailUsuario;
        string contraseñaUsuario;
        public Form2()
        {
            InitializeComponent();
            ventanaPrincipal = new Form1();
        }
        public void setCuenta(string nombre, string contraseña )
        {
            mailUsuario = nombre;
            contraseñaUsuario = contraseña;
        }

        private void botonEnviar_Click(object sender, EventArgs e)
        {

            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.To.Add(textReceptor.Text);
                mensaje.Subject = textAsunto.Text;
                mensaje.Body = textMensaje.Text;
                mensaje.IsBodyHtml = true;
                mensaje.From = new MailAddress(mailUsuario);

                SmtpClient usuario = new SmtpClient("smtp-mail.outlook.com", 587);
                usuario.UseDefaultCredentials = false;
                usuario.EnableSsl = true; //Seguridad
                usuario.Credentials = new NetworkCredential(this.mailUsuario, this.contraseñaUsuario);
                usuario.Send(mensaje);
                MessageBox.Show("Mensaje Enviado");
                mensaje.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Verifique si los datos ingresados en el inicio de sesion son correcto o si el mail receptor es correcto");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int x, y;


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            else
            {
                Left += e.X - x;
                Top += e.Y - y;
            }
        }
    }
}
