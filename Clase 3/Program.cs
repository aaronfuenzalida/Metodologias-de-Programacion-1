using System.Collections;
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Collections;
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Models;
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Interfaces;
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Factory;
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Iterator;
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Strategy;

namespace Metodologias_de_Programacion.Clase_3_Factory__Observer
{
	class Program
	{
		public static void Main(string[] args)
		{	
			//Ejercicio 9 -------
			Pila pila = new Pila();
			Console.Write("Ingrese nombre del comparable que desea crear: ");
			string opcion = Console.ReadLine();
			if(opcion == "Profesor")
			{
				
			}
			llenar(pila,opcion);
			cambiarEstrategia(pila,new PorNombre());
			Console.WriteLine("------------- Compara por nombre -------------");
			informar(pila,opcion);
			cambiarEstrategia(pila,new PorLegajo());
			Console.WriteLine("------------- Compara por legajo -------------");
			informar(pila,opcion);
			cambiarEstrategia(pila,new PorPromedio());
			Console.WriteLine("------------- Compara por Promedio -------------");
			informar(pila,opcion);
			cambiarEstrategia(pila,new PorDni());
			Console.WriteLine("------------- Compara por DNI -------------");
			informar(pila,opcion);
			
			Console.ReadKey(true);
		}
		
		//Ejercicio 2 --------
		public static void llenar(IColeccionable coleccionable, string opcion) 
		{
			for (int i= 1 ; i <= 20; i++)
			{
				Comparable c = FabricaDeComparables.CrearAleatorio(opcion);
				coleccionable.agregar(c);
			}
		}
		
		public static void informar(IColeccionable coleccionable, string opcion)
		{
			Console.WriteLine("Cantidad de elementos: " + coleccionable.cuantos());
			Console.WriteLine("Minimo: " + coleccionable.minimo());
			Console.WriteLine("Maximo: " + coleccionable.maximo());
			Comparable c = FabricaDeComparables.CrearPorTeclado(opcion);
			if (coleccionable.contiene(c))
			{
				Console.WriteLine("El elemento leído está en la colección");
			}
			else
			{
				Console.WriteLine("El elemento leído no está en la colección");
			}
		}
	
		//--------------------------
		
		
		//Ejercicio 6 -----
		public static void imprimirElementos(IColeccionable coleccionable){
			IIterador iterador = ((IIterable)coleccionable).crearIterador();
			iterador.primero();
			while(!iterador.fin()){
				Console.WriteLine(iterador.actual());
				iterador.siguiente();
			}
		}
		//-----
		
		//Ejercicio 8 ------
		public static void cambiarEstrategia(IColeccionable coleccionable, IEstrategia estrategia){
			IIterador iterador = ((IIterable)coleccionable).crearIterador();
			iterador.primero();
			while(!iterador.fin()){
				Comparable elemento= iterador.actual();
				Alumno alumno = (Alumno)elemento;
        		alumno.cambiarEstrategia(estrategia);
        		iterador.siguiente();
			}
		}
		// ----------
	}
}