/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 16:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Clase_2___Strategy___Iterator
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto : IColeccionable , IIterable
	{
		private List<Comparable> datos;
		
		public Conjunto()
		{
			this.datos = new List<Comparable>();
		}
		
		public void agregar(Comparable elemento){
			if(!this.pertenece(elemento)){
				datos.Add(elemento);
			}
			else{
				Console.WriteLine("El elemento a agregar ya se encuentra en la lista");
			}
		
		}
		
		public bool pertenece(Comparable elemento){
			return this.contiene(elemento);
		}
		
		public bool contiene(Comparable elemento){
		foreach(Comparable e in this.datos){
        	if(e.sosIgual(elemento)){
            return true; 
        	}
    	}
    	return false;
		}
		
		public int cuantos(){
		return this.datos.Count;
		}
		
		public Comparable maximo(){
			Comparable max= this.datos[0];
    		foreach(Comparable elemento in this.datos){
    			if(elemento.sosMayor(max)){
    			max=elemento;
    			}
    		}
    		return max;
		}
		
		public Comparable minimo(){
		Comparable min= this.datos[0];
    		foreach(Comparable elemento in this.datos){
    			if(elemento.sosMenor(min)){
    			min=elemento;
    			}
    		}
    		return min;
		}
		
		public IIterador crearIterador(){
			return new IteradorDeLista(this.datos);
		}
	}
}
