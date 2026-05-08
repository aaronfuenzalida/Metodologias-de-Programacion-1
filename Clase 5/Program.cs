using System.Collections;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Collections;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Models;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Interfaces;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Factory;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Iterator;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Strategy;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Adapter;

namespace Metodologias_de_Programacion.Clase_5_Proxy__Command
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
			StudentsFactory sf = new StudentsFactory();
			sf.setAleatorioON();

			StudentStudiousFactory ssf = new StudentStudiousFactory();
			ssf.setAleatorioON();
			for (int i= 0 ; i < 20; i++)
			{
				if(i >= 10)
				{
					/*Comparable alumno = FabricaDeComparables.CrearAleatorio("Alumno");
					Student alumnoAdapter = new AlumnoAdapter((Alumno)alumno);
					teacher.goToClass(alumnoAdapter);*/
					teacher.goToClass(sf.studentDecoration());

				}
				else
				{
					/*Comparable alumno = FabricaDeComparables.CrearAleatorio("AlumnoEstudioso");
					Student alumnoMuyEstudiosoAdapter = new AlumnoAdapter((Alumno)alumno);
					teacher.goToClass(alumnoMuyEstudiosoAdapter);*/
					teacher.goToClass(ssf.StudentStudiousDecoration());

				}
			}
			teacher.teachingAClass();

		}
		
	}
}
