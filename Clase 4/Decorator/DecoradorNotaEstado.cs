using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Decorator
{
    public class DecoradorNotaEstado : DecoradorAlumno
    {
        public DecoradorNotaEstado(IAlumno alumno) : base(alumno){}

        public override string mostrarCalificacion()
        {
            string estado;
            if (base.getNota() >= 7) estado = "PROMOCION";
            else if (base.getNota() >= 4) estado = "APROBADO";
            else estado = "DESAPROBADO";

            string textoAnterior = base.mostrarCalificacion();
            return $"{textoAnterior} ({estado})";
        }
    }
}