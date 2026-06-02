using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Interfaces;

namespace Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Decorator
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