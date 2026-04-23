/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 7/4/2026
 * Time: 17:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Clase_1
{

	public class Numero : Comparable
	{
		private int valor;
		
		public Numero(int v){
			this.valor = v;
		}
		
		public int getValor(){
		return this.valor;
		}
		
		public bool sosIgual(Comparable valor) {
			return ((Numero)valor).getValor() == this.valor;
    	}

    	public bool sosMenor(Comparable valor) {
			return ((Numero)valor).getValor() > this.valor;
		}

    	public bool sosMayor(Comparable valor) {
			return ((Numero)valor).getValor() < this.valor;
    	}
		
		public override string ToString()
		{
			return string.Format("{0}", valor);
		}

			
	}
}
