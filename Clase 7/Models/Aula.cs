using System.Diagnostics.Contracts;
using System.Runtime;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Adapter;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models
{
    public class Aula
    {
        private Teacher teacher;

        public void comenzar()
        {
            Console.WriteLine("Comienza la clase");
            this.teacher = new Teacher();
        }

        public void nuevoAlumno(IAlumno alumno)
        {
            Student alumnoAdaptado = new AlumnoAdapter(alumno);
            this.teacher.goToClass(alumnoAdaptado);
        }

        public void claseLista()
        {
            this.teacher.teachingAClass();
        }
        
    }
}
