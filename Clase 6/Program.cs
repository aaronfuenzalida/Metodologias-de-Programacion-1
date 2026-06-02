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
            // La fabrica ya brinda un alumno compuesto aleatorio, con 5 alumnos adentro
            AlumnoCompuesto grupoDeAlumnos = (AlumnoCompuesto)FabricaDeComparables.CrearAleatorio("AlumnoCompuesto");
            Student alumnoAdapter = new AlumnoAdapter(grupoDeAlumnos);
            teacher.goToClass(alumnoAdapter);
            teacher.teachingAClass();
        }
    }
}