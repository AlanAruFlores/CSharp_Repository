using System;
using System.Collections.Generic;
using System.Text;

namespace Threads
{
    class Usuario
    {
        private string nombre;
        private int edad;
        private string email;

        public Usuario(string nombre, int edad, string email)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.email = email;
        }

        public override string ToString()
        {
            return nombre + " | " + edad + " | "+email;
        }


        //Getters and Setters
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string Email { get; set; }
    }
}
