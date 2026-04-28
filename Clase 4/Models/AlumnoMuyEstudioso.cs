namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Models
{
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string n, int d, int l, int p) : base(n, d, l, p)
        {
        }

        public override int responderPregunta(int pregunta)
        {
            return pregunta % 3 ;
        }
    }

}