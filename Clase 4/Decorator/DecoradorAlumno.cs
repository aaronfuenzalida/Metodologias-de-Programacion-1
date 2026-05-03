using Metodologias_de_Programacion.Clase_4_Adapter__Decorator;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Models;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Decorator
{
    public abstract class DecoradorAlumno : IAlumno
    {
        protected IAlumno adicional; 

        public DecoradorAlumno(IAlumno alumno)
        {
            this.adicional = alumno;
        }

        public virtual void cambiarEstrategia(IEstrategia nvaEstrategia) => adicional.cambiarEstrategia(nvaEstrategia);
        public virtual int getLegajo() => adicional.getLegajo();
        public virtual int getPromedio() => adicional.getPromedio();
        public virtual string getNombre() => adicional.getNombre();
        public virtual int getDni() => adicional.getDni();
        public virtual int getNota() => adicional.getNota();
        public virtual void setNota(int cal) => adicional.setNota(cal);
        public virtual int responderPregunta(int pregunta) => adicional.responderPregunta(pregunta);
        
        public virtual string mostrarCalificacion() => adicional.mostrarCalificacion();

        public virtual bool sosIgual(Comparable c) => adicional.sosIgual(c);
        public virtual bool sosMenor(Comparable c) => adicional.sosMenor(c);
        public virtual bool sosMayor(Comparable c) => adicional.sosMayor(c);
    }
}