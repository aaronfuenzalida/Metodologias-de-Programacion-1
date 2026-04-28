/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 15:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Strategy;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Models
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona , IObservador
	{
		private int legajo;
		private int promedio;
		private IEstrategia estrategia;
		
		public Alumno(string n,int d,int l, int p) :base(n,d)
		{
			this.legajo= l;
			this.promedio= p;
			this.estrategia = new PorDni();
		}
		
		public void cambiarEstrategia(IEstrategia nEstrategia){
		this.estrategia = nEstrategia;
		}
	
		
		public int getLegajo(){
			return this.legajo;
		}
		
		public int getPromedio(){
		return this.promedio;
		}
		
		public override string ToString(){
			return this.getNombre() + " (DNI: " + this.getDni() + ")" + "(PROMEDIO: " + this.getPromedio() + ")";
		}
		
		public override bool sosIgual(Comparable persona) => !this.sosMenor(persona) && !this.sosMayor(persona);

		public override bool sosMenor(Comparable persona) => estrategia.comparar((Alumno)persona, this);

		public override bool sosMayor(Comparable persona) => estrategia.comparar(this, (Alumno)persona);

		public void prestarAtencion()
		{
			Console.WriteLine("Prestando atención");
		}

		public void distraerse()
		{
			string[] distracciones = {"Dibujando en el margen de la carpeta", "Mirando el celuar", "Tirando aviones de papel" };
			Random rand = new Random();
			int index = rand.Next(distracciones.Length);
			Console.WriteLine(distracciones[index]);
		}

		void IObservador.actualizar(IObservado o)
		{
			if (o is Profesor profesor)
			{
				if (profesor.estaHablando())
				{
					this.prestarAtencion();
				}
				else
				{
					this.distraerse();
				}
			}
		}
	}
}


