namespace Metodologias_de_Programacion.Clase_5_Proxy__Command.Interfaces
{
    public interface IObservado
        {
            void agregarObservador(IObservador o);
            void quitarObservador(IObservador o);
            void notificar();
        }
}