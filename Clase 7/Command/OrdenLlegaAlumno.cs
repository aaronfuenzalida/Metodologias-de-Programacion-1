using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models;
namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Command
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
