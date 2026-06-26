namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces
{
    public interface IObservado
        {
            void agregarObservador(IObservador o);
            void quitarObservador(IObservador o);
            void notificar();
        }
}
