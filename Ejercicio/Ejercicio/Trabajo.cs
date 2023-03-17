using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio
{
    class Trabajo
    {
        public bool esExamen;
        public int cantPuntos;
        public bool esVirtual;

        public Trabajo(bool esExamen, int cantPuntos, bool esVirtual)
        {
            this.esExamen = esExamen;
            this.cantPuntos = cantPuntos;
            this.esVirtual = esVirtual;
        }

        public bool esEasy()
        {
            return this.esExamen == false && this.cantPuntos < 4 && this.esVirtual == true;
        }
    }
}
