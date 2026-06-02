namespace Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Interfaces
{
    public interface IObservado
        {
            void agregarObservador(IObservador o);
            void quitarObservador(IObservador o);
            void notificar();
        }
}