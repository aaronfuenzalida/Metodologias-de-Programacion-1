using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Factory;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Strategy;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models;
using System.Text;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Proxy
{
    public class AlumnoProxy : IAlumno{
        private IAlumno alumnoReal = null;
        private string nombre;
        private int dni;
        private int legajo;
        private int promedio;
        private int calificacion;
        private int opcion;
        private IEstrategia estrategia;

        public AlumnoProxy(string nombre, int dni, int legajo, int promedio, int opcion)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.legajo = legajo;
            this.promedio = promedio;
            this.opcion = opcion;
            this.estrategia = new PorDni();
        }

        public string getNombre() => this.nombre;
    
        public int getDni() => this.dni;

        public void cambiarEstrategia(IEstrategia nvaEstrategia)
        {
            this.estrategia = nvaEstrategia;
        }

        public int getLegajo() => this.legajo;

        public int getPromedio() => this.promedio;

        public int getNota() => this.calificacion;

        public void setNota(int cal)
        {
            this.calificacion = cal;
        }

        public string mostrarCalificacion() => new StringBuilder().Append(this.getNombre()).Append(" ").Append(this.getNota()).ToString();

        public int responderPregunta(int pregunta)
        {
            if(alumnoReal == null)
            {
                Console.WriteLine("Creando alumno real");
                if (this.opcion == 1)
                {
                    alumnoReal = new Alumno(this.nombre, this.dni, this.legajo, this.promedio);
                }
                else if (this.opcion == 2)
                {
                    alumnoReal = new AlumnoMuyEstudioso(this.nombre, this.dni, this.legajo, this.promedio);
                }
            }
            return alumnoReal.responderPregunta(pregunta);
        }

        public bool sosIgual(Comparable persona) => !this.sosMenor(persona) && !this.sosMayor(persona);

        public bool sosMenor(Comparable persona) => this.estrategia.comparar((IAlumno)persona, this);

        public bool sosMayor(Comparable persona) => this.estrategia.comparar(this, (IAlumno)persona);

        
    }



}
