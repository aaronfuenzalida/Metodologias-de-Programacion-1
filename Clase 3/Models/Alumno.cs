/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 15:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Interfaces;
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Strategy;

namespace Metodologias_de_Programacion.Clase_3_Factory__Observer.Models
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona
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
	}
}


