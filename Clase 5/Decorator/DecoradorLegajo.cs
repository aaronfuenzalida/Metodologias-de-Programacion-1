using Metodologias_de_Programacion.Clase_5_Proxy__Command.Interfaces;

namespace Metodologias_de_Programacion.Clase_5_Proxy__Command.Decorator
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