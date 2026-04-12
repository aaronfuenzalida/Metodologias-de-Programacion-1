/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 9/4/2026
 * Time: 20:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Clase_1
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	public class ColeccionMultiple : IColeccionable
	{
		private Cola cola;
		private Pila pila;
		
		public ColeccionMultiple(Cola cola, Pila pila)
		{
			this.cola= cola;
			this.pila= pila;
		}
		
		public int cuantos(){
			return this.cola.cuantos() + this.pila.cuantos();
		}
		
		public Comparable minimo(){
			Comparable minCola= this.cola.minimo();
			Comparable minPila= this.pila.minimo();
			
			if(minCola.sosMenor(minPila)){
				return minCola;
			}
			else{
				return minPila;
			}
		}
		
		public Comparable maximo(){
			Comparable maxCola= this.cola.maximo();
			Comparable maxPila= this.pila.maximo();
			
			if(maxCola.sosMayor(maxPila)){
				return maxCola;
			}
			else{
				return maxPila;
			}
		}
		
		public void agregar(Comparable comparable){
			Console.WriteLine("Vacio");
		}
		
		public bool contiene(Comparable valor){
			if(this.cola.contiene(valor) || this.pila.contiene(valor)){
				return true;
			}
			else{
				return false;
			}
		}
	}
}
