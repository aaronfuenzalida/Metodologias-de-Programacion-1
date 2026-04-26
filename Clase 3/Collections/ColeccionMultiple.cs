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
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Iterator;

namespace Metodologias_de_Programacion.Clase_3_Factory__Observer.Collections
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	public class ColeccionMultiple : IColeccionable , IIterable
	{
		private Cola cola;
		private Pila pila;
		
		public ColeccionMultiple(Cola cola, Pila pila)
		{
			this.cola= cola;
			this.pila= pila;
		}
		
public void agregar(Comparable c)
        {
            throw new NotImplementedException();
        }

        public bool contiene(Comparable c)
        {
            return this.pila.contiene(c) || this.cola.contiene(c);
        }

        public int cuantos()
        {
            return this.pila.cuantos() + this.cola.cuantos();
        }

        public Comparable maximo()
        {
            return (this.pila.maximo().sosMayor(this.cola.maximo())) ? this.pila.maximo() : this.cola.maximo();
        }

        public Comparable minimo()
        {
            return (this.pila.minimo().sosMenor(this.cola.minimo())) ? this.pila.minimo() : this.cola.minimo();
        }

		public Pila getPila()
		{
			return this.pila;
		}

		public Cola getCola()
		{
			return this.cola;
		}

		public IIterador crearIterador()
		{
			return new IteradorDeColeccionMultiple(this);
		}
	}
}

