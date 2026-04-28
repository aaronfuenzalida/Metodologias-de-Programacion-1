/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 17/4/2026
 * Time: 16:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Iterator
{
	/// <summary>
	/// Description of IteradorDeCola.
	/// </summary>
	public class IteradorDeCola : IIterador
	{
		private List<Comparable> datos;
		private int indiceActual;
		
		public IteradorDeCola(List<Comparable> elementos)
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
