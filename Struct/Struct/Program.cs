using System;
using System.Text;
using System.Net;
using System.Threading;
namespace Struct
{
    class Program
    {


        static void Main(string[] args)
        {
            int utf32 = 244;
            char c = Convert.ToChar(utf32);
            Console.WriteLine("" +c);

        }

        struct WEPSecurity64
        {
            public readonly static int IVLength = 4;
            public static int WordSize;
            public static byte[] integrity;
            public static char[] seed = new char[16];
            public static char[] key = new char[10];
            public static char[] iv = new char[6];

            public void Start(string msj)
            {
                Thread h1 = new Thread(() => GettingCRC(msj));
                Thread h2 = new Thread(() => ExecutingRC4());
                h1.Start();
                h2.Start();
                h1.Join();
                h2.Join();
                var h3 = new Thread(()=>GenerateSeed());
                h3.Start();
                h3.Join();
            }

            public static void GettingCRC(string msj)
            {
                for (int i = 0; i < msj.Length; i++) integrity[i] = Convert.ToByte(msj[i]);
            }
            public static void ExecutingRC4()
            {
                for (int i = 0; i < 10; i++) key[i] = Convert.ToChar(ReturningNumber());
                for (int i = 0; i < 6; i++) iv[i] = Convert.ToChar(ReturningNumber());
            }
            public static void GenerateSeed()
            {
                for (int i = 0; i < 16; i++)
                {
                    if (i < 4) seed[i] = iv[i];
                    else seed[i] = key[i];
                }
            }

            private static int ReturningNumber()
            {
                return new Random().Next(0,16);
            }
            private static void ShowingData()
            {
                Console.WriteLine("")
            }

        }


        
        public static string getCaracters(int bytes)
        {
            string txtRandom = "";
            while (bytes >= 0)
            {
                int n = new Random().Next(0, characters.Length);
                txtRandom += characters[n];
                bytes--;
            }
            return txtRandom;
        }
        /*public static void structExample()
        {
            AutoStruct auto;
            auto.marca = "Chevrolet";
            auto.cantRuedas = 4;
            auto.color = "Verde";

            Console.WriteLine(auto);

            var value = auto;
            value.color = "Rojo";
            Console.WriteLine(auto);
        }
        public static void classExample()
        {
            AutoClass auto = new AutoClass();
            auto.cantRuedas = 4;
            auto.marca = "Ford";
            auto.color = "Verde";

            Console.WriteLine(auto);
            var value = auto;
            value.color = "Rojo";
            Console.WriteLine(auto);
        }

        public static void usingReadOnlyStruc()
        {
            Coords coordenadas = new Coords(2, 2);
            Console.WriteLine(coordenadas);


        }
        public static void usingReadOnlyPeople()
        {
            //Persona persona = new Persona("Pepe", 24);

            //Console.WriteLine(persona);
        }
    }


    //Usamos readonlhy cuando queremos que solo las propiedades sean de lectura por lo que no podre cambiar los valores;
    public readonly struct Coords
    {
        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }
        public  double Y { get;  }
        public  double X {  get;  }
    
        public readonly override string ToString() => $"({X}, {Y})";
    }

    struct Persona
    {
        private string nombre;
        private int edad;
        private int suma;
        public string Nombre { get => nombre; set => nombre = value;}
        public int Edad { get => edad; set => edad = value; }

        //Las structs siempre deben instanciar los atributos
        public Persona(string nombre, int edad,int suma) {
            this.nombre = nombre;
            this.edad = edad;
            this.suma = suma;
        }
        public readonly void realizarSuma(int x, int y)
        {
            // suma = x + y; --> no se puede asignar valores a miembros de la estructura si el metodo es readonly, solo se puede con variables locales
            int local = x + y;
        }

        public readonly override string ToString() => "Persona" + Nombre + "Edad: " + Edad;
    }
    struct AutoStruct
    {
        public String marca;
        public int cantRuedas;
        public String color;

        public override string ToString()
        {
            return "MARCA: " + marca + " | CANTIDAD DE RUEDAS: " + cantRuedas + " | " + color;
        }
    }
    class AutoClass
    {
        public string marca;
        public int cantRuedas;
        public string color;

        public override string ToString()
        {
            return "MARCA: " + marca + " | CANTIDAD DE RUEDAS: " + cantRuedas + " | " + color;
        }
    }
        */
    }
}
