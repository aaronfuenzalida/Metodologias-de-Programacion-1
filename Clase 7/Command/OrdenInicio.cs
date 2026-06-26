using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models;
namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Command
{
    public class OrdenInicio : IOrdenEnAula1
    {
        private Aula aula;
        public OrdenInicio(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar()
        {
            this.aula.comenzar();
        }
    }
}
