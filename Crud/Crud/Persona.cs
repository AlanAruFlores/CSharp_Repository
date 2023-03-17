using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    class Persona
    {
        private int id;
        private string nombre;
        private int edad;


        public Persona(int id, string nombre, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
        }
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public Persona(int id)
        {
            this.id = id;
        }

        public int Id{
            set => this.id = value;
            get => this.id;
        }

        public string Nombre
        {
            set => this.nombre = value;
            get => this.nombre;
        }

        public int Edad
        {
            set => this.edad = value;
            get => this.edad;
        }
        override
        public string ToString()
        {
            return "ID: " + this.id + " | NOMBRE: " + this.nombre + " | EDAD: " + this.edad;
        }
    }
}
