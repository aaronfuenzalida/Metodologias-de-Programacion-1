namespace Metodologias_de_Programacion.Clase_5_Proxy__Command.Interfaces
{
    public interface IOrdenable
    {
        void setOrdenInicio(IOrdenEnAula1 orden);
        void setOrdenLlegaAlumno(IOrdenEnAula2 orden);
        void setAulaLlena(IOrdenEnAula1 orden);
    }
}