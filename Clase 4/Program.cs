using System.Collections;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Collections;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Models;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Factory;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Iterator;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Strategy;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Adapter;
using System.Net.NetworkInformation;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator
{
	class Program
	{
		public static void Main(string[] args)
		{	
		testAdapter();

		Console.ReadKey(true);
		}

		public static void testAdapter()
		{
			Teacher teacher = new Teacher();
			for (int i= 0 ; i < 20; i++)
			{
				if(i >= 10)
				{
					Comparable alumno = FabricaDeComparables.CrearAleatorio("Alumno");
					Student alumnoAdapter = new AlumnoAdapter((Alumno)alumno);
					teacher.goToClass(alumnoAdapter);
				}
				else
				{
					Comparable alumno = FabricaDeComparables.CrearAleatorio("AlumnoEstudioso");
					Student alumnoMuyEstudiosoAdapter = new AlumnoAdapter((Alumno)alumno);
					teacher.goToClass(alumnoMuyEstudiosoAdapter);

				}
			}
			teacher.teachingAClass();

		}
		
	}
}
