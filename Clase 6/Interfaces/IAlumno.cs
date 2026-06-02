namespace Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Interfaces
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