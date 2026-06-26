using System;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Factory
{
    public class FabricaDeAlumnosEstudiosos : FabricaDeComparables
    {
        public override Comparable crearComparable()
        {
            if(opcionActual == 2) Console.WriteLine("--- Ingrese datos del Alumno Estudioso ---");
            
            string nombre = manejador.cadena(10, opcionActual);
            int dni = manejador.numero(100000000, opcionActual);
            int legajo = manejador.numero(10000, opcionActual);
            int promedio = manejador.numero(10, opcionActual);

            return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio);
        }
    }
}