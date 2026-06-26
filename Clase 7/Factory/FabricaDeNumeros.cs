
using System;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Factory
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable crearComparable()
        {
            if(opcionActual == 2) Console.WriteLine("--- Ingrese un Numero ---");
            
            // Pide un numero con tope 1000. La cadena decide de donde lo saca.
            int valor = manejador.numero(1000, opcionActual);
            
            return new Numero(valor);
        }
    }
}