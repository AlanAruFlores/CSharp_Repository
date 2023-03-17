using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Ejercicio
{
    class Alumno : IDisposable
    {
        int nroLegajo;
        string nombre;
        string apellido;
        int curso;
        ArrayList listaTrabajos = new ArrayList();
        public Alumno(int nroLegajo, string nombre, string apellido, int curso)
        {
            this.nroLegajo = nroLegajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.curso = curso;
        }

        public void setTrabajo(Trabajo trabajo)
        {
            this.listaTrabajos.Add(trabajo);
        }
        public int tenerCantExamen()
        {
            int contadorExamen = 0;
            foreach(Trabajo trabajo in listaTrabajos)
            {
                if(trabajo.esExamen == true)
                {
                    contadorExamen++;
                }
            }
            return contadorExamen;
        }
        public int tenerCantidadNoEasy()
        {
            int contador = 0;

            foreach(Trabajo trabajo in listaTrabajos)
            {
                if(trabajo.esEasy() == false)
                {
                    contador++;
                }
            }
            return contador;
        }
        public bool indicarSiTPFisico()
        {
            bool tpFisico = false;
            foreach(Trabajo trabajo in listaTrabajos)
            {
                if(trabajo.esVirtual ==false && trabajo.cantPuntos > 5)
                {
                    tpFisico = true;
                }
            }

            return tpFisico;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
       
        public string mostrarInformacion()
        {
            return this.nombre + " | " + this.nroLegajo;
        }

    }
}
