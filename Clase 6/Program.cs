using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Adapter;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Factory;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Interfaces;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Composite;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.TemplateMethod;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Models;
using System.Runtime;

namespace Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //testAdapter();   <--- Ejercicio 2
            Persona p1 = (Persona)FabricaDeComparables.CrearAleatorio("Profesor");
            Persona p2 = (Persona)FabricaDeComparables.CrearAleatorio("Profesor");

            JuegoDeCartas juego = new CartaBomba();
            JuegoDeCartas juego2 = new JuegoDeGuerra();

            Persona ganador = juego.jugar(p1, p2);
            Persona ganador2 = juego2.jugar(p1, p2);
            Console.WriteLine($"\nGanador de carta bomba: {ganador.getNombre()}");
            Console.WriteLine($"\nGanador de la guerra: {ganador2.getNombre()}");
        }

       /*public static void testAdapter() <--- Ejercicio 2
        {
            Teacher teacher = new Teacher();
            // La fabrica ya brinda un alumno compuesto aleatorio, con 5 alumnos adentro
            AlumnoCompuesto grupoDeAlumnos = (AlumnoCompuesto)FabricaDeComparables.CrearAleatorio("AlumnoCompuesto");
            Student alumnoAdapter = new AlumnoAdapter(grupoDeAlumnos);
            teacher.goToClass(alumnoAdapter);
            teacher.teachingAClass();
        }
        */
    }
}