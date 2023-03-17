using System;
using System.Collections.Generic;
namespace EjercicioHogarNaval
{
    class Program
    {
        static Pokemon[] pokemonesIniciales = {
            new Pikachu("Pika"),
            new Charizard("Char"),
            new Sceptile("Sceptil")
        };


        static void Main(string[] args)
        {
            
            Personaje miPersonaje = crearPersonaje();
            seleccionarPokemon(miPersonaje);

            Console.Clear();
            //miPersonaje.mostrarEquipo();
            Console.WriteLine("COMBATE!!!!");
            miPersonaje.elegirPokemon();
            iniciarPelea(miPersonaje);
        }
        static Pokemon seleccionarPokemonEnemigo()
        {
            int num = new Random().Next(0, 3);
            return pokemonesIniciales[num];
        }
        static void iniciarPelea(Personaje personaje)
        {
            Console.Clear();
            Pokemon pokemonLuchador = seleccionarPokemonEnemigo();
            int opcion;
            bool terminado = false;
            do
            {
                Console.Clear();
                Console.WriteLine(pokemonLuchador.Sprite+"\t\t"+pokemonLuchador.ToString());
                Console.WriteLine("\n\n");
                Console.WriteLine(pokemonLuchador.Sprite + "\t\t" + personaje.PokemonActual.ToString());
                opcion = elegirOpcion();
                switch (opcion)
                {
                    case 1:
                        {
                            personaje.PokemonActual.atacar(pokemonLuchador);
                            Console.WriteLine("Turno del contraacante");
                            pokemonLuchador.atacar(personaje.PokemonActual);
                            if(personaje.PokemonActual.HP <= 0 || pokemonLuchador.HP <= 0)
                            {
                                terminado = true;
                            }
                            break;
                        }
                    case 2:
                        {
                            terminado = true;break;
                        }
                }
            } while (terminado != true);
        }
        static int  elegirOpcion()
        {
            int opcion;
            do
            {
                Console.WriteLine("ELEGI UNA OPCION:\n[1]ATACAR POKEMON\n[2]HUIR ");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion < 1 || opcion >2);
            return opcion;
        }
        static Personaje crearPersonaje()
        {
            Console.WriteLine("-------------CREAR PERSONAJE---------------");
            Console.Write("NOMBRE: ");
            string name = Console.ReadLine();
            Console.Write("GENERO (M/F): ");
            char type = char.Parse(Console.ReadLine());
            return new Personaje(name, type);
        }
        static void seleccionarPokemon(Personaje personaje)
        {
            int opcionPokemon;

            do
            {
                Console.WriteLine("SELECCIONE UN POKEMON PARA SU AVENTURA");
                for (int i = 0; i < pokemonesIniciales.Length; i++)
                    Console.WriteLine("[" + (i + 1) + "]" + pokemonesIniciales[i].ToString());
                opcionPokemon = int.Parse(Console.ReadLine());
            } while (opcionPokemon < 1 || opcionPokemon > pokemonesIniciales.Length);

            personaje.agregarPokemon(pokemonesIniciales[opcionPokemon - 1]);
        }
    }
    //Personaje
    class Personaje {
        private string name;
        private char type;
        private List<Pokemon> miEquipo;
        private Pokemon pokemonActual;
        public Personaje(string name, char type)
        {
            this.name = name;
            this.type = type;
            this.miEquipo = new List<Pokemon>();
        }

        public void agregarPokemon(Pokemon pokemon)
        {
            this.miEquipo.Add(pokemon);
        }
        public void mostrarEquipo()
        {
            Console.Clear();
            int i = 0;
            Console.WriteLine("---------------MI EQUIPO------------------");
            foreach(Pokemon pokemon in miEquipo)
            {
                i++;
                Console.WriteLine("["+i+"]"+pokemon);
            }
        }
        public void elegirPokemon()
        {
            if(miEquipo.Count == 0)
                Console.WriteLine("NO TIENE UN POKEMON");
            else
            {
                mostrarEquipo();
                int opcion = 0;
                do
                {
                    opcion = int.Parse(Console.ReadLine());
                } while (opcion < 1 || opcion >miEquipo.Count);
                this.pokemonActual = miEquipo[opcion - 1];
            }
        }
        public override string ToString()=>"PERSONAJE:\nNombre:"+this.name+"\nGenero: "+this.type;
        public Pokemon PokemonActual
        {
            get => this.pokemonActual;
        }
    }

    //Componentes
    interface IPokemon
    {
        void atacar(Pokemon pokemon);
        void huir();
    }
    //TIPOS DISPONIBLES
    enum Tipo
    {
        AGUA,
        FUEGO,
        PLANTA,
        ELECTRICIDAD
    }

    //Clase Abstracta
    abstract class  Pokemon : IPokemon{
        private string name;
        private int level;
        private int xp;
        private int hp;
        private Tipo tipo;
        private string sprite;
        protected Pokemon(string name, int level, Tipo tipo)
        {
            this.name = name;
            this.level = level;
            this.tipo = tipo;
            this.hp = 100;
            this.xp = 0;
            setSprite();
        }    
        protected Pokemon(string name, Tipo tipo)
        {
            this.name = name;
            this.tipo = tipo;
            this.level = 0;
            this.hp = 100;
            this.xp = 0;
            setSprite();
        }

        private void setSprite()
        {
            this.sprite = "(/_/) \n"+
            "(^_ ^)\n"+
            "(___)O";
        }
        //Metodos Abstractos
        public abstract void atacar(Pokemon pokemon);
        //Metodo de la instancia
        public void huir()
        {
            Console.WriteLine("Huyendo....");
        }
        public override string ToString() => this.name + " | " + this.level + " | " + this.hp;

        public string Sprite
        {
            get => this.sprite;
            set => this.sprite = value;
        }
        public int HP
        {
            get => this.hp;
            set => this.hp = value;
        }
    }

    //Clases Hijas

    class Charizard : Pokemon
    {
        public Charizard(string name, int level) : base(name, level, Tipo.FUEGO)
        {
        }
        public Charizard(string name) : base(name, Tipo.FUEGO){
        }

        public override void atacar(Pokemon pokemon)
        {
            Console.WriteLine("Lanzando Fuego....");
            pokemon.HP = pokemon.HP - 10;
        }

    }
    class Pikachu : Pokemon
    {
        public Pikachu(string name, int level) : base(name, level, Tipo.ELECTRICIDAD)
        {
        }
        public Pikachu(string name) : base(name, Tipo.ELECTRICIDAD)
        {
        }

        public override void atacar(Pokemon pokemon)
        {
            Console.WriteLine("Lanzando Rayo....");
            pokemon.HP = pokemon.HP - 10;

        }

    }
    class Sceptile : Pokemon
    {
        public Sceptile(string name, int level) : base(name, level, Tipo.PLANTA)
        {
        }
        public Sceptile(string name) : base(name, Tipo.PLANTA)
        {
        }

        public override void atacar(Pokemon pokemon)
        {
            Console.WriteLine("Lanzando Plantas....");
            pokemon.HP = pokemon.HP - 10;

        }

    }

}



