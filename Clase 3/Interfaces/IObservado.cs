namespace Metodologias_de_Programacion.Clase_3_Factory__Observer.Interfaces
{
    public interface IObservado
        {
            void agregarObservador(IObservador o);
            void quitarObservador(IObservador o);
            void notificar();
        }
}