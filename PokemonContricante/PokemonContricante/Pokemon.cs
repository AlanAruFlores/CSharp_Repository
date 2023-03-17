using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonContricante
{
    abstract class Pokemon
    {
        private string nombre;
        private int cantVida;
        private int cantAtaque;
        private Tipo tipoPokemon;
        private string urlImage;
        public Pokemon(string nombre, int cantVida, Tipo tipoPokemon, int cantAtaque, string image)
        {
            this.nombre = nombre;
            this.cantVida = cantVida;
            this.tipoPokemon = tipoPokemon;
            this.cantAtaque = cantAtaque;
            this.urlImage = image;
        }

        public void receiveAttack(int daño)
        {
            this.cantVida -= daño;
        }

        public int doAttack()=>new Random().Next(10, 20);
        
        /*Getters and Setters*/
        public string Nombre
        {
            get => this.nombre;
            set => this.nombre = value;
        }
        public int CantVida
        {
            get => this.cantVida;
            set => this.cantVida = value;
        }
        public Tipo TipoPokemon
        {
            get => this.tipoPokemon;
            set => this.tipoPokemon = value;
        }
        public int CantAtaque
        {
            get => this.cantAtaque;
            set => this.cantAtaque = value;
        }
        public string UrlImage
        {
            get => this.urlImage;
            set => this.urlImage = value;
        }
    }
}
