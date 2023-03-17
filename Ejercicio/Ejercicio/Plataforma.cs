using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Ejercicio
{
    class Plataforma
    {
        ArrayList listaAlumnos = new ArrayList();

        public Plataforma(){
        }

        public int retornarAlumnosTipoExamen()
        {
            int contador = 0;
            foreach(Alumno alumno in listaAlumnos)
            {
                if (alumno.tenerCantExamen() >=3)
                {
                    contador++;
                }
            }
            return contador;
        }
        public bool indicarAlumnoFisico()
        {
            bool existe = false;
            foreach(Alumno alumno in listaAlumnos)
            {
                if(alumno.indicarSiTPFisico() == true)
                {
                    existe = true;
                }
            }
            return existe;
        }

        public ArrayList tenerAlumnosNoEasy()
        {
            ArrayList listaAlumnosNoEasy = new ArrayList();

            foreach(Alumno alumno in listaAlumnos)
            {
                if (alumno.tenerCantidadNoEasy() >= 2)
                {
                    listaAlumnosNoEasy.Add(alumno);
                }
            }

            return listaAlumnosNoEasy;
        }
    }
}
