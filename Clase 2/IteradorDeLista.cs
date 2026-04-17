/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 17/4/2026
 * Time: 16:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Clase_2___Strategy___Iterator
{
	/// <summary>
	/// Description of IteradorDeLista.
	/// </summary>
	public class IteradorDeLista : IIterador
	{
		private List<Comparable> datos;
		private int indiceActual;
		
		public IteradorDeLista(List<Comparable> elementos)
		{
			this.datos=elementos;
			this.primero();
		}
		
		public void primero(){
			this.indiceActual=0;
		}
		
		public void siguiente(){
			this.indiceActual++;
		}
		
		public bool fin(){
			return indiceActual >= this.datos.Count;
		}
		
		public Comparable actual(){
			return this.datos[this.indiceActual];
		}
	}
}
