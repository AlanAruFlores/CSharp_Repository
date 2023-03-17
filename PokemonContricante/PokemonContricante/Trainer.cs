using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonContricante
{
    class Trainer
    {
        private string nombrePersonaje;

        public Trainer()
        {
            this.nombrePersonaje = "Gary";
        }
        public string NombrePersonaje
        {
            get => this.nombrePersonaje;
            set => this.nombrePersonaje = value;
        }
    }
}
