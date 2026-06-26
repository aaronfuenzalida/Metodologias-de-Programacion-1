using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Decorator
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
