/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 12/4/2026
 * Time: 11:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Clase_1
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
		
		public string getNombre(){
		return this.nombre;
		}
		
		public int getDni(){
		return this.dni;
		}
		
		//Se elige  comparar por dni
		
		public virtual bool sosIgual(Comparable persona){
			if(this.getDni() == ((Persona)persona).getDni()){
				return true;
			}
			else{
			return false;
			}
		}
		
		public virtual bool sosMenor(Comparable persona){
			if(this.getDni() < ((Persona)persona).getDni()){
			return true;
			}
			else{
			return false;
			}
		}
		
		public virtual bool sosMayor(Comparable persona){
		if(this.getDni() > ((Persona)persona).getDni()){
			return true;
			}
			else{
			return false;
			}
		}
	}
}
