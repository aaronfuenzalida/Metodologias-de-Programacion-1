using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Decorator
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
