/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 16:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Interfaces;
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Iterator;

namespace Metodologias_de_Programacion.Clase_3_Factory__Observer.Collections
{
	public class Pila : IColeccionable, IIterable
	{
    	private List<Comparable> datos = new List<Comparable>();

    	public void Apilar(Comparable elem)
    	{
        datos.Add(elem);
    	}

    	public Comparable Desapilar()
    	{
        	int indiceUltimo = datos.Count - 1;
        	Comparable temp = datos[indiceUltimo];
        	datos.RemoveAt(indiceUltimo);
        	return temp;
    	}

    	public Comparable Tope()
    	{
        	return datos[datos.Count - 1];
    	}

    	public bool EsVacia(){
    		return this.datos.Count == 0;
    	} 

    	public int CantidadElementos(){
    		return this.datos.Count;
    	}
    	
    	public int cuantos(){
			return this.datos.Count;
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
		
		public Comparable maximo(){
			Comparable max= this.datos[0];
    		foreach(Comparable elemento in this.datos){
    			if(elemento.sosMayor(max)){
    			max=elemento;
    			}
    		}
    		return max;
		}
		
		public void agregar(Comparable valor){
    		this.Apilar(valor);
		}
		
		public bool contiene(Comparable valor){
    		foreach(Comparable elemento in this.datos){
    			if(elemento.sosIgual(valor)){
    			return true;
    			}
    		}
    		return false;
		}
    	
    	public IIterador crearIterador(){
    		return new IteradorDePila(this.datos);
    	}
    	
		
	}
}
