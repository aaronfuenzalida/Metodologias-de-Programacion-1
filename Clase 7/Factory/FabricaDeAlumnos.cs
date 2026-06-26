using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Proxy;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Factory
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        public override Comparable crearComparable()
        {
            if(opcionActual == 2) Console.WriteLine("--- Ingrese datos del Alumno ---");
            
            string nombre = manejador.cadena(10, opcionActual);
            int dni = manejador.numero(100000, opcionActual);
            int legajo = manejador.numero(10, opcionActual);
            int promedio = manejador.numero(100, opcionActual);

            return new AlumnoProxy(nombre, dni, legajo, promedio, 1);
        }
    }
}