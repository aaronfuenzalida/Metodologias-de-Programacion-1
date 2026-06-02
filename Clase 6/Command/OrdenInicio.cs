using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Interfaces;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Models;
namespace Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Command
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
