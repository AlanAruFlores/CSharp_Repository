using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaSQL
{
    class Genero
    {
        private int id;
        private string nombre;

        public Genero(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }


        //Metodos getter y setters
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

    }
}
