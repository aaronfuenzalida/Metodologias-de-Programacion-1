namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces
{
    public interface IOrdenable
    {
        void setOrdenInicio(IOrdenEnAula1 orden);
        void setOrdenLlegaAlumno(IOrdenEnAula2 orden);
        void setAulaLlena(IOrdenEnAula1 orden);
    }
}
