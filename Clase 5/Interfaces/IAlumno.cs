namespace Metodologias_de_Programacion.Clase_5_Proxy__Command.Interfaces
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