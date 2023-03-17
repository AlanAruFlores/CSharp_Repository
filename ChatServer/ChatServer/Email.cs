using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    class Email
    {
        SmtpClient cliente;

        public Email()
        {
            cliente = new SmtpClient("smtp-mail.outlook.com", 587);
            cliente.UseDefaultCredentials = false;
            cliente.EnableSsl = true; 
            cliente.Credentials = new NetworkCredential("miprueba242@hotmail.com", "prueba242");
        }

        public void enviarMensaje()
        {
            try
            {
                string rutaArchivo = @"C:\Users\Usuario\source\repos\ChatServer\ChatServer\bin\Debug\historial.txt";
                MailMessage mensaje = new MailMessage();
                mensaje.To.Add("alangta242@hotmail.com");
                mensaje.Subject = "Informacion del Chat";
                mensaje.Body = enviarHTML();
                mensaje.IsBodyHtml = true;
                mensaje.From = new MailAddress("miprueba242@hotmail.com");
                mensaje.Attachments.Add(new Attachment(rutaArchivo));
                cliente.Send(mensaje);
                MessageBox.Show("Mensaje Enviado");
                mensaje.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string enviarHTML()
        {
            string cuerpoHTML = "<h1>Gracias por usar mi programa</h1>";
            cuerpoHTML += "<p>Aca le dejo el archivo adjunto del historial</p>";
            cuerpoHTML += "<p>Cualquier duda, mandeme un mensaje a <b>miprueba242@hotmail.com</b></p>";
            return cuerpoHTML;
        }
    }
}
