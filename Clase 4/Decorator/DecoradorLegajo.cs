using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Decorator
{
    public class DecoradorLegajo : DecoradorAlumno
    {
        public DecoradorLegajo(IAlumno alumno) : base(alumno)
        {
        }

        public override string mostrarCalificacion()
        {
            return $"{base.getNombre()} ({base.getLegajo()}) {base.getNota()}";
        }
    }
}