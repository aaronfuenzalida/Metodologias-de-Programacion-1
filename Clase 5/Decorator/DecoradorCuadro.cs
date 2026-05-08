using Metodologias_de_Programacion.Clase_5_Proxy__Command.Interfaces;
namespace Metodologias_de_Programacion.Clase_5_Proxy__Command.Decorator
{
    public class DecoradorCuadro : DecoradorAlumno
    {
        public DecoradorCuadro(IAlumno alumno) : base(alumno)
        {
        }

        public override string mostrarCalificacion()
        {
           string contenido = base.mostrarCalificacion();

           string borde = new string('*', contenido.Length + 4);

           return $"{borde}\n* {contenido} *\n{borde}";
        }
    }

}