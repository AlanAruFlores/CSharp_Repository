using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Threads
{
    class ArchivoTexto
    {
        public static void createFIle(string name)
        {
            TextWriter archivoTexto = new StreamWriter(name);
            archivoTexto.Close();

            if (File.Exists(name))
                Console.WriteLine("El archivo de texto ya existe");
        }

        public static void addText(string text, string name)
        {
            TextWriter archivoTexto = new StreamWriter(name);
            archivoTexto.WriteLine(text);
            archivoTexto.Close();
        }

        public static void appendText(string text, string name)
        {

            TextWriter archivoTexto = File.AppendText(name);
            archivoTexto.WriteLine(text);
            archivoTexto.Close();
        }

        public static string readFile(string name)
        {
            string content = "";
            try
            {
                string line = "";
                TextReader archivoTexto = new StreamReader(name);
                while((line = archivoTexto.ReadLine()) != null)
                {
                    content += line+"\n";
                }
                archivoTexto.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return content;
        }
    }
}
