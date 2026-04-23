/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 9/4/2026
 * Time: 16:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Clase_1
{

    public class Cola : IColeccionable
    {
        private List<Comparable> datos = new List<Comparable>();
        
        public void encolar(Comparable elem)
        {
            this.datos.Add(elem);
        }
        
        public Comparable desencolar()
        {
            Comparable temp = this.datos[0];
            this.datos.RemoveAt(0);
            return temp;
        }
        
        public int cuantos()
        {
            return this.datos.Count;
        }
        
        public Comparable minimo()
        {
            Comparable min = this.datos[0];
            foreach(Comparable elemento in this.datos)
            {
                if (elemento.sosMenor(min))
                {
                    min = elemento;
                }
            }
            return min;
        }
        
        public Comparable maximo()
        {
            Comparable max = this.datos[0];
            foreach(Comparable elemento in this.datos)
            {
                if(elemento.sosMayor(max))
                {
                    max = elemento;
                }
            }
            return max;
        }
        
        public void agregar(Comparable valor)
        {
            this.encolar(valor); 
        }
        
        public bool contiene(Comparable valor)
        {
            foreach(Comparable elemento in this.datos)
            {
                if (elemento.sosIgual(valor))
                {
                    return true;
                }
            }
            return false;
        }
    }
}