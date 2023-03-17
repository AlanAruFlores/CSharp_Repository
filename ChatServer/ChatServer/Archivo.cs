using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace ChatServer
{
    class Archivo
    {
        public Archivo(string nombreArchivo)
        {
            crearArchivo(nombreArchivo);
        }
        public void crearArchivo(string nombreArchivo)
        {
            if (File.Exists(nombreArchivo) == false) { 
                TextWriter archivo = new StreamWriter(nombreArchivo);
                archivo.Close();
            }
        }
        public void escribirArchivo(string nombreArchivo, string contenido)
        {
            TextWriter archivoTxt = File.AppendText(nombreArchivo);
            archivoTxt.WriteLine(contenido);
            archivoTxt.Close();
        }
        public static string leerArchivo(string nombreArchivo)
        {
            string msj = "";
            try
            {
                TextReader archivo = new StreamReader(nombreArchivo);
                string line = archivo.ReadLine();
                while (line != null)
                {
                    msj += line;
                    line = archivo.ReadLine();
                }
                archivo.Close();
            }catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return msj;
        }
    }
}
