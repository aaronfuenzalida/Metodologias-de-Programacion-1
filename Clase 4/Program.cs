using System.Collections;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Collections;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Models;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Factory;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Iterator;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Strategy;
using System.Net.NetworkInformation;

namespace Metodologias_de_Programacion.Clase_4_Adapter_Decorator
{
	class Program
	{
		public static void Main(string[] args)
		{	
		/*Ejercicio 9 -------
		Pila pila = new Pila();
		Console.Write("Ingrese nombre del comparable que desea crear: ");
		string opcion = Console.ReadLine();
		
		llenar(pila, opcion);

		if(opcion == "Profesor")
		{
			// PRUEBAS EXCLUSIVAS PARA PROFESOR
			cambiarEstrategia(pila, new PorNombre());
			Console.WriteLine("------------- PROFESOR: Compara por nombre -------------");
			informar(pila, opcion);

			cambiarEstrategia(pila, new PorDni());
			Console.WriteLine("------------- PROFESOR: Compara por DNI -------------");
			informar(pila, opcion);

			cambiarEstrategia(pila, new PorAntiguedad());
			Console.WriteLine("------------- PROFESOR: Compara por Antigüedad -------------");
			informar(pila, opcion);
		}
		else if (opcion == "Alumno")
		{
			// PRUEBAS EXCLUSIVAS PARA ALUMNO 
			cambiarEstrategia(pila, new PorNombre());
			Console.WriteLine("------------- ALUMNO: Compara por nombre -------------");
			informar(pila, opcion);

			cambiarEstrategia(pila, new PorLegajo());
			Console.WriteLine("------------- ALUMNO: Compara por legajo -------------");
			informar(pila, opcion);

			cambiarEstrategia(pila, new PorPromedio());
			Console.WriteLine("------------- ALUMNO: Compara por Promedio -------------");
			informar(pila, opcion);

			cambiarEstrategia(pila, new PorDni());
			Console.WriteLine("------------- ALUMNO: Compara por DNI -------------");
			informar(pila, opcion);
		}
		else
		{
			informar(pila, opcion);
		}
		*/

		//Ejercicio 14

		Profesor profesor = new Profesor("Pedro", 12345678, 10);
		for (int i = 1; i<=20; i++)
		{
			Comparable alumno = FabricaDeComparables.CrearAleatorio("Alumno");
			profesor.agregarObservador((IObservador)alumno);
		}
		DictadoDeClases(profesor);

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
		
		public static void cambiarEstrategia(IColeccionable coleccionable, IEstrategia estrategia)
		{
			IIterador iterador = ((IIterable)coleccionable).crearIterador();
			iterador.primero();
			
			while(!iterador.fin())
			{
				Comparable elemento = iterador.actual();
				
				//Por que chequear el tipo de elemento?↓↓↓
				//Existen estrategias que son exclusivas de cada SUBCLASE!!

				if (elemento is Alumno)
				{
					((Alumno)elemento).cambiarEstrategia(estrategia);
				}
				else if (elemento is Profesor)
				{
					((Profesor)elemento).cambiarEstrategia(estrategia);
				}
				
				iterador.siguiente();
			}
		}

		//Ejercicio 13
		public static void DictadoDeClases(Profesor p){
			for(int i= 1 ; i <= 5; i++){
				p.hablarALaClase();
				p.escribirEnElPizarron();
			}
		}
	}
}
