/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 16:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Interfaces;

namespace Metodologias_de_Programacion.Clase_3_Factory__Observer.Models
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	abstract public class Persona : Comparable
	{
		private string nombre;
		private int dni;
		
		public Persona(string n,int d)
		{
			this.nombre= n;
			this.dni= d;
		}
		
        public string getNombre() => nombre;

        public int getDni() => dni;

        public virtual bool sosIgual(Comparable c) => dni == ((Persona)c).getDni();

        public virtual bool sosMenor(Comparable c) => dni < ((Persona)c).getDni();

        public virtual bool sosMayor(Comparable c) => dni > ((Persona)c).getDni();

        public override string ToString() => string.Format("[Persona: Nombre={0}, Dni={1}]", nombre, dni);
	}
}
