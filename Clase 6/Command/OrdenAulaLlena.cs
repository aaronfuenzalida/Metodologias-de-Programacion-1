using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Interfaces;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Models;
namespace Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Command
{
    public class OrdenAulaLlena : IOrdenEnAula1
    {
        private Aula aula;
        public OrdenAulaLlena(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar()
        {
            this.aula.claseLista();
        }
    }
}