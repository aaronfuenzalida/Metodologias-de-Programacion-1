using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Models;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Adapter
{
    public class AlumnoMuyEstudiosoAdapter : AlumnoAdapter
    {
         public AlumnoMuyEstudiosoAdapter(AlumnoMuyEstudioso alumno) : base(alumno)
        {
        }

    }
}