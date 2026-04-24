namespace Clase_3_Factory__Observer
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Ejercicio 2 --------
			//Pila pila2 = new Pila();
			//Cola cola2 = new Cola();
			//ColeccionMultiple multiple= new ColeccionMultiple(cola2,pila2);
			//llenarAlumnos(pila2);
			//llenarAlumnos(cola2);
			//informar(multiple);
			// --------
			
			//Ejercicio 7 --------
			//Pila pila = new Pila();
			//Cola cola= new Cola();
			//Conjunto conjunto = new Conjunto();
			//llenarAlumnos(pila);
			//llenarAlumnos(cola);
			//llenarAlumnos(conjunto);
			//Console.WriteLine("--------------------- Elementos de pila---------------------");
			//imprimirElementos(pila);
			//Console.WriteLine("--------------------- Elementos de cola---------------------");
			//imprimirElementos(cola);
			//Console.WriteLine("--------------------- Elementos de conjunto---------------------");
			//imprimirElementos(conjunto);
			
			//Ejercicio 9 -------
			Pila pila = new Pila();
			llenarAlumnos(pila);
			cambiarEstrategia(pila,new PorNombre());
			Console.WriteLine("------------- Compara por nombre -------------");
			informar(pila);
			cambiarEstrategia(pila,new PorLegajo());
			Console.WriteLine("------------- Compara por legajo -------------");
			informar(pila);
			cambiarEstrategia(pila,new PorPromedio());
			Console.WriteLine("------------- Compara por Promedio -------------");
			informar(pila);
			cambiarEstrategia(pila,new PorDni());
			Console.WriteLine("------------- Compara por DNI -------------");
			informar(pila);
			
			Console.ReadKey(true);
		}
		
		static Random aleatorio = new Random();
		
		//Ejercicio 2 --------
		public static void llenarAlumnos (IColeccionable coleccionable){
			string[] nombres= new string[]{"Marcos","Mateo","Pedro","Ignacio","Carlos","Valentina","Victoria","Adriana","Emilia","Matias"};
			for(int i=0 ; i<20 ; i++){
				int indiceAleatorio= aleatorio.Next(0,nombres.Length);
				Alumno al = new Alumno(nombres[indiceAleatorio],aleatorio.Next(45000000, 48000000),aleatorio.Next(1000,1200),aleatorio.Next(1,11));
		//Se comenta la siguiente linea para el ejercicio 7: al.cambiarEstrategia(new PorPromedio());
				coleccionable.agregar(al);
			}
		}
		
		public static void informar(IColeccionable coleccionable){
			//Nota: Unicamente se modifico el ToString de alumno para mostrar la nota en vez del legajo.
			Console.WriteLine("El collecionable contiene {0} elementos",coleccionable.cuantos());
			Console.WriteLine("Elemento minimo del coleccionable: {0}", coleccionable.minimo());
			Console.WriteLine("Elemento maximo del collecionables: {0}", coleccionable.maximo());
			//Depende de la estrategia a utilizar ↓↓↓↓↓ 
            Console.WriteLine("--- Búsqueda de Alumno ---");

            Console.Write("Ingrese el Nombre para verificar: ");
            string nombreBuscado = Console.ReadLine() ?? "";

            Console.Write("Ingrese el DNI para verificar: ");
            int dniBuscado = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingrese el Legajo para verificar: ");
            int legajoBuscado = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Ingrese el Promedio para verificar: ");
            int promedioBuscado = int.Parse(Console.ReadLine() ?? "0");

            Comparable valor = new Alumno(nombreBuscado, dniBuscado, legajoBuscado, promedioBuscado);

            if (coleccionable.contiene(valor))
            {
                Console.WriteLine("El elemento leído ESTÁ en la colección");
            }
			else{
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