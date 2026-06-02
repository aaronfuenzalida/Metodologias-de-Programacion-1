using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Adapter;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Factory;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Interfaces;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Composite;

namespace Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            testAdapter();
        }

       public static void testAdapter()
        {
            Teacher teacher = new Teacher();
            AlumnoCompuesto alumnoCompuesto = new AlumnoCompuesto();
    
            for (int i = 0 ; i < 5; i++)
            {
                Comparable alumno = FabricaDeComparables.CrearAleatorio("Alumno");
                alumnoCompuesto.agregarAlumno((IAlumno)alumno);
            }
    
            Student alumnoAdapter = new AlumnoAdapter(alumnoCompuesto);
    
            teacher.goToClass(alumnoAdapter);
    
            teacher.teachingAClass();
        }
    }
}