using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaSQL
{
    class Persona
    {
        private int id;
        private string nombre;
        private int edad;
        private int idGenero;
        public Persona(int id,string nombre,int edad, int idGenero)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.idGenero = idGenero;
        }
        public Persona(string nombre, int edad, int idGenero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.idGenero = idGenero;
        }

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public string Nombre
        {
            get => this.nombre;
            set => this.nombre = value;
        }
        public int Edad
        {
            get => this.edad;
            set => this.edad = value;
        }
        public int IdGenero
        {
            get => this.idGenero;
            set => this.idGenero = value;
        }
    }
}
