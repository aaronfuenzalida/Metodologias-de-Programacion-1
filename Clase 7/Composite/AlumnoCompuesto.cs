using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Composite
{
    public class AlumnoCompuesto : IAlumno
    {
        private List<IAlumno> alumnos;

        public AlumnoCompuesto()
        {
            this.alumnos = new List<IAlumno>();
        }

        public void agregarAlumno(IAlumno a)
        {
            this.alumnos.Add(a);
        }

        public string getNombre()
        {
            if(this.alumnos.Count > 0)
            {
                string nombres = "";
                foreach(IAlumno a in this.alumnos)
                {
                    nombres += a.getNombre() + ", ";
                }
                return nombres;
            }
            return "No hay alumnos en la lista";
        }

        public int responderPregunta(int pregunta)
        {
            List<int> respuestas = new List<int>();
            foreach(IAlumno a in this.alumnos)
            {
                respuestas.Add(a.responderPregunta(pregunta));
            }

            // Se usa LINQ para obtener cual fue la respuesta mas repetida de los alumnos
            int respuestaGanadora = respuestas.GroupBy(r => r)
                                      .OrderByDescending(grupo => grupo.Count())
                                      .Select(grupo => grupo.Key)
                                      .FirstOrDefault();

            return respuestaGanadora;
        }

        public void setNota(int cal)
        {
            foreach(IAlumno a in this.alumnos)
            {
                a.setNota(cal);
            }
        }

        public string mostarCalificacion()
        {
            string calificaciones = "";
            foreach(IAlumno a in this.alumnos)
            {
                calificaciones += a.mostrarCalificacion() + "\n";
            }
            return calificaciones;
        }

        public bool sosIgual(Comparable c)
        {
            //Se utiliza LINQ nuevamente. Ahorra lineas de codigo y funciona de igual manera 
            //que un foreach preguntando si algun alumno es igual al comparado
            return this.alumnos.Any(a => a.sosIgual(c));
        }

        public bool sosMenor(Comparable c)
        {
            return this.alumnos.All(a => a.sosMenor(c));
        }

        public bool sosMayor(Comparable c)
        {
            return this.alumnos.All(a => a.sosMayor(c));
        }

        //Se implementa el resto de metodos de interfaces por mas que no se pida en la practica 
        public void cambiarEstrategia(IEstrategia nvaEstrategia)
        {
            foreach(IAlumno a in this.alumnos)
            {
                a.cambiarEstrategia(nvaEstrategia);
            }
        }

        public int getLegajo()
        {
            return 0;
        }

        public int getPromedio()
        {
            return 0;
        }

        public int getNota()
        {
            return 0;
        }

        public string mostrarCalificacion()
        {
            // string.Join junta todos los elementos de la lista separados por el primer parametro ("\n")
            return string.Join("\n", this.alumnos.Select(a => a.mostrarCalificacion()));
        }

        public int getDni()
        {
            return 0;
        }
    }

}
