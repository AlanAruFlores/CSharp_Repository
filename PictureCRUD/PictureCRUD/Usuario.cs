using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureCRUD
{
    class Usuario
    {
        private int id;
        private string nombre;
        private byte[] imagen;

        public Usuario(int id, string nombre, byte[] imagen)
        {
            this.id = id;
            this.nombre = nombre;
            this.imagen = imagen;
        }
        public Usuario(string nombre, byte[] imagen)
        {
            this.nombre = nombre;
            this.imagen = imagen;
        }
        public Usuario(int id)
        {
            this.id = id;
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
        public byte[] Imagen
        {
            get => this.imagen;
            set => this.imagen = value;
        }
    }
}
