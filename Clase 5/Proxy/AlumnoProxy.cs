using Metodologias_de_Programacion.Clase_5_Proxy__Command.Interfaces;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Factory;
using System.Text;

namespace Metodologias_de_Programacion.Clase_5_Proxy__Command.Proxy
{
    public class AlumnoProxy : IAlumno{
        private IAlumno alumnoReal = null;
        private string nombre;
        private int dni;
        private int legajo;
        private int promedio;
        private int calificacion;
        private string opcion;
        private IEstrategia estrategia;

        public AlumnoProxy(string nombre, int dni, int legajo, int promedio, string opcion,IEstrategia estrategia)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.legajo = legajo;
            this.promedio = promedio;
            this.opcion = opcion;
            this.estrategia = estrategia;
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
            //TODO: IMPLEMENTACION RESTANTE A CONSULTAR
        }

        public bool sosIgual(Comparable persona) => !this.sosMenor(persona) && !this.sosMayor(persona);

        public bool sosMenor(Comparable persona) => this.estrategia.comparar((IAlumno)persona, this);

        public bool sosMayor(Comparable persona) => this.estrategia.comparar(this, (IAlumno)persona);

        
    }



}