/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 12/4/2026
 * Time: 11:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Clase_1
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona
	{
		private int legajo;
		private int promedio;
		
		public Alumno(string n,int d,int l, int p) :base(n,d)
		{
			this.legajo= l;
			this.promedio= p;
		}
		
		public int getLegajo(){
			return this.legajo;
		}
		
		public int getPromedio(){
		return this.promedio;
		}
		
		public override string ToString(){
			return this.getNombre() + " (DNI: " + this.getDni() + ")" + "(LEGAJO: " + this.getLegajo() + ")";
		}
		
		public override bool sosMenor(Comparable persona){
    		if(this.getLegajo() < ((Alumno)persona).getLegajo())
    		{
        		return true;
    		}
    		else
    		{
        		return false;
    		}
		}
		
		public override bool sosMayor(Comparable persona){
			if(this.getLegajo() > ((Alumno)persona).getLegajo())
			{
			return true;
			}
			else{
			return false;
			}
		}
		
		public override bool sosIgual(Comparable persona){
			if(this.getLegajo() == ((Alumno)persona).getLegajo()){
			   	return true;
			   }
			   else{
			   return false;
			   }
		}
	}
}
