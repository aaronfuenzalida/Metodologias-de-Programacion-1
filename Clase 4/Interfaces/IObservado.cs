namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces
{
    public interface IObservado
        {
            void agregarObservador(IObservador o);
            void quitarObservador(IObservador o);
            void notificar();
        }
}