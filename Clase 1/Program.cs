/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 7/4/2026
 * Time: 17:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Clase_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Ejercicio 7: Implemente un módulo main que cree una Pila y una Cola, que las llene y que invoque a la
			// función informar con la pila y cola creadas.
			//Cola cola= new Cola();
			//Pila pila= new Pila();
			
			//llenar(pila);
			//llenar(cola);
			
			//informar(pila);
			//informar(cola);
			
			//Ejercicio 9: Modifique el módulo main para crear una ColeccionMultiple e informe con esta colección.
			
			//ColeccionMultiple coleccionM= new ColeccionMultiple(cola,pila);
			//informar(coleccionM);
			
			//Ejercicio 14
			Console.WriteLine("---ALUMNOS---");
			
			Pila pila2 = new Pila();
			Cola cola2 = new Cola();
			ColeccionMultiple multiple= new ColeccionMultiple(cola2,pila2);
			llenarAlumnos(pila2);
			llenarAlumnos(cola2);
			informar(multiple);
			
			Console.ReadKey(true);
		}
		
		//Evitar que las colecciones se llenen con los mismos numeros
		static Random aleatorio = new Random();
		
		//Ejercicio 5:Implemente una función llenar que reciba un Coleccionable y que le agregue 20 comparables elegidos al azar.

		public static void llenar(IColeccionable coleccionable){
			for(int i=0 ; i < 20;i++){
				coleccionable.agregar(new Numero(aleatorio.Next(1,200)));
			}
		}
		
		//Ejercicio 6: Implemente una función informar que reciba un Coleccionable e imprima por consola la
		// cantidad de elementos que tiene el coleccionable recibido por parámetro, el elemento
		// mínimo, el máximo y si contiene, o no, como elemento un valor leído por teclado.
		
		public static void informar(IColeccionable coleccionable){
			Console.WriteLine("El collecionable contiene {0} elementos",coleccionable.cuantos());
			Console.WriteLine("Elemento minimo del coleccionable: {0}", coleccionable.minimo());
			Console.WriteLine("Elemento maximo del collecionables: {0}", coleccionable.maximo());
			
			//Se tuvo que comentar el siguiente bloque para que funcione el Ejercicio 14 (De igual manera se encuentra comentado el bloque correspondiente a este codigo)
			
			// Console.Write("Ingrese el valor de un elemento para verificar si el comparable lo contiene: ");
			// Comparable valor= new Numero(int.Parse(Console.ReadLine()));
			//	if(coleccionable.contiene(valor)){
			//	Console.WriteLine("El elemento leído está en la colección");
			//}
			
			//De igual manera el siguiente bloque no funciona como es debido ya que se esta comparando por LEGAJO segun lo pedido en el punto 15
			Console.Write("Ingrese un DNI para verificar si la colección lo contiene: ");
			int dniBuscado = int.Parse(Console.ReadLine());
			Comparable valor = new Alumno("", dniBuscado, 0, 0);
				if(coleccionable.contiene(valor)){
				Console.WriteLine("El elemento leído está en la colección");
			}
			else{
			Console.WriteLine("El elemento leído no está en la colección");
			}
			
		}
		
		//Ejercicio 13: Implemente una función llenaAlumnos que reciba un Coleccionable y que le agregue 20 alumnos elegidos al azar.
		
		public static void llenarAlumnos (IColeccionable coleccionable){
			string[] nombres= new string[]{"Marcos","Mateo","Pedro","Ignacio","Carlos","Valentina","Victoria","Adriana","Emilia","Matias"};
			for(int i=0 ; i<20 ; i++){
				int indiceAleatorio= aleatorio.Next(0,nombres.Length);
				Alumno al = new Alumno(nombres[indiceAleatorio],aleatorio.Next(45000000, 48000000),aleatorio.Next(1000,1200),aleatorio.Next(1,10));
				coleccionable.agregar(al);
			}
		}
		

		
		
	}
}
