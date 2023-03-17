using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Usuario
    {
        private int id;
        private string nombre;
        private string contraseña;
        private int coins;



        public Usuario(int id, string nombre, string contraseña)
        {
            this.id = id;
            this.nombre = nombre;
            this.contraseña = contraseña;
        }

        public Usuario(string nombre, string contraseña)
        {
            this.nombre = nombre;
            this.contraseña = contraseña;
        }
        public Usuario(int id , int coins)
        {
            this.id = id;
            this.coins = coins;
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
        public string Contraseña
        {
            get => this.contraseña;
            set => this.contraseña = value;
        }
        public int Coin
        {
            get => this.coins;
            set => this.coins = value;
        }
    }
}
