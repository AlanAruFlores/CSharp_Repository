using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ChatServer
{
    class Sevidor
    {


        private TcpListener escuchador;
        private TcpClient cliente;
        private IPEndPoint direccion = new IPEndPoint(IPAddress.Any, 2134);
        private List<Connection> conexiones = new List<Connection>();

        public Form1 ventanaPrincipal;
        Connection conexionActual;
        private Archivo archivoTexto;

        public Sevidor(Form1 form)
        {
            ventanaPrincipal = form;
            new Thread(() =>
            {
                archivoTexto = new Archivo("historial.txt");
            }).Start();
        }


        public void Iniciar()
        {
            escuchador = new TcpListener(direccion);
            escuchador.Start();
            while (true)
            {
                cliente = escuchador.AcceptTcpClient();
                conexionActual = new Connection(cliente);
                conexiones.Add(conexionActual);
                ventanaPrincipal.actualizarRegistro();
                new Thread(Escuchando).Start();
            }
            

        }
        public void Escuchando()
        {
            Connection usuario = conexionActual;
            do
            {
                try
                {
                    string contenido = usuario.leer.ReadLine();
                    string msj = usuario.nombreUsuario + ": "+contenido;
                    this.archivoTexto.escribirArchivo("historial.txt", msj);
                    if (contenido == "exit")
                    {
                        conexiones.Remove(usuario);
                        ventanaPrincipal.actualizarRegistro();
                        MessageBox.Show("Se ha desconectado: " + usuario.nombreUsuario);
                    }
                    foreach (Connection conn in conexiones)
                    {
                        conn.escribir.WriteLine(msj);
                        conn.escribir.Flush();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    break;
                }
            } while (true);
        }

        public void eliminarUsuario(string id)
        {
            int idConexion = int.Parse(id);
            Connection usuarioEliminar = encontrarUsuario(idConexion);
            if (usuarioEliminar == null) MessageBox.Show("No se encontro el usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                usuarioEliminar.escribir.WriteLine("close");
                usuarioEliminar.escribir.Flush();
                conexiones.Remove(usuarioEliminar);
                ventanaPrincipal.actualizarRegistro();
            }
        }
        private Connection encontrarUsuario(int id)
        {
            Connection valor = null;
            foreach(Connection conn in conexiones)
            {
                if (conn.id == id) {
                    valor = conn;
                };
            }
            return valor;
        }

        public List<Connection> getConexiones()
        {
            return this.conexiones;
        } 
    }
    
}
