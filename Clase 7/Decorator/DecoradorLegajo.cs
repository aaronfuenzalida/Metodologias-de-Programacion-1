using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Decorator
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
