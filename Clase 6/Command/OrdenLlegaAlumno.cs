using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Interfaces;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Models;
namespace Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Command
{
    public class OrdenLlegaAlumno : IOrdenEnAula2
    {
        private Aula aula;
        public OrdenLlegaAlumno(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar(Comparable alumno)
        {
            this.aula.nuevoAlumno((IAlumno)alumno);
        }
    }
}