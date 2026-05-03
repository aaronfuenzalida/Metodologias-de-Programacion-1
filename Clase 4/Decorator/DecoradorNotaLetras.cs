using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Decorator
{
    public class DecoradorNotaLetras : DecoradorAlumno
    {
        public DecoradorNotaLetras(IAlumno alumno) : base(alumno)
        {
        }

        public override string mostrarCalificacion()
        {
            string calificacion;
            switch (base.getNota())
            {
                case 10:
                    calificacion = "DIEZ";
                    break;
                case 9:
                    calificacion = "NUEVE";
                    break;
                case 8:
                    calificacion = "OCHO";
                    break;
                case 7:
                    calificacion = "SIETE";
                    break;
                case 6:
                    calificacion = "SEIS";
                    break;
                case 5:
                    calificacion = "CINCO";
                    break;
                case 4:
                    calificacion = "CUATRO";
                    break;
                case 3:
                    calificacion = "TRES";
                    break;
                case 2:
                    calificacion = "DOS";
                    break;
                case 1:
                    calificacion = "UNO";
                    break;
                default:
                    calificacion = "CERO / SIN NOTA" ;
                    break;
            }
            string textoAnterior = base.mostrarCalificacion();
            return $"{textoAnterior} ({calificacion})";
        }
    }
}
