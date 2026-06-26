using System;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Factory
{
    public class FabricaDeProfesores : FabricaDeComparables
    {
        public override Comparable crearComparable()
        {
            if(opcionActual == 2) Console.WriteLine("--- Ingrese datos del Profesor ---");
            
            string nombre = manejador.cadena(10, opcionActual);
            int dni = manejador.numero(100000000, opcionActual);
            int antiguedad = manejador.numero(20, opcionActual);

            return new Profesor(nombre, dni, antiguedad);
        }
    }
}