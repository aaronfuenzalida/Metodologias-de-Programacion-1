using Metodologias_de_Programacion.Clase_5_Proxy__Command.Interfaces;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Models;
namespace Metodologias_de_Programacion.Clase_5_Proxy__Command.Command
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
