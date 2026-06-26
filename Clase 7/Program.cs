using System;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Factory;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Composite;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cinco Alumnos generando datos aleatoriamente
            Console.WriteLine("Creando 5 Alumnos Aleatorios");
            for (int i = 0; i < 5; i++)
            {
                IAlumno a = (IAlumno)FabricaDeComparables.CrearAleatorio("Alumno");
                Console.WriteLine($"Aleatorio creado: {a.getNombre()}");
            }

            // Dos AlumnoMuyEstudioso leyendo datos desde teclado
            Console.WriteLine("Creando 2 Alumnos Estudiosos");
            for (int i = 0; i < 2; i++)
            {
                IAlumno am = (IAlumno)FabricaDeComparables.CrearPorTeclado("AlumnoEstudioso");
                Console.WriteLine($"Estudioso creado: {am.getNombre()}");
            }

            // Cinco alumnos compuestos creados leyendo desde archivo
            Console.WriteLine("Creando Alumnos desde Archivo (Composite) ");
            AlumnoCompuesto compuesto = new AlumnoCompuesto();
            for (int i = 0; i < 5; i++)
            {
                IAlumno archivoAlumno = (IAlumno)FabricaDeComparables.CrearDesdeArchivo("Alumno");
                compuesto.agregarAlumno(archivoAlumno);
            }

            Console.WriteLine("\n=== LISTA DE ALUMNOS DEL ARCHIVO ===");
            Console.WriteLine(compuesto.getNombre());
        }
    }
}
