using Metodologias_de_Programacion.Clase_5_Proxy__Command.Interfaces;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Models;
namespace Metodologias_de_Programacion.Clase_5_Proxy__Command.Command
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