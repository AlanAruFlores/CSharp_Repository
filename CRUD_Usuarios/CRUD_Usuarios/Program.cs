using System;
using LayerNegotiation;
using LayerModel;
using System.Collections.Generic;

namespace CRUD_Usuarios
{
    class Program
    {
        static Negocio_Usuario negocio = new Negocio_Usuario();
        static void Main(string[] args)
        {
            Testing();

        }
        static void Testing()
        {
            /*
            Usuario usuario = new Usuario("Pepe", "pepe@gmail.com", 24);
            negocio.saveUserInDB(usuario);
            
            */
            //negocio.deleteUserInDB(2);
            /*
            List<Usuario> list = negocio.getAllUsersInDB();
            foreach(Usuario obj in list)
            {
                Console.WriteLine(obj.ShowState());
            }
            */
            /*
            Usuario usuario = new Usuario(10,"Pepe", "pepe@gmail.com", 24);
            negocio.updateUserInDB(usuario);
            */

        }
        static void ShowMenu()
        {
            Console.WriteLine("----------MENU--------");
            Console.WriteLine("[1]CREAR USUARIO" +
                "\n[2]MOSTRAR USUARIOS" +
                "\n[3]MOSTRAR USUARIO ID" +
                "\n[4]EDITAR USUARIO" +
                "\n[5]ELIMINAR USUARIO ID" +
                "\n[6]SALIR");
        }
    }
}
