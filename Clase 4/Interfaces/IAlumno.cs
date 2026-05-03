namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces
{
    public interface IAlumno : IPersona
    {
        void cambiarEstrategia(IEstrategia nvaEstrategia);
        int getLegajo();
        int getPromedio();
        int getNota();
        void setNota(int cal);
        int responderPregunta(int pregunta);
        string mostrarCalificacion();
    }
}