/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 15:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Iterator;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Collections
{

    public class Cola : IColeccionable, IIterable, IOrdenable
    {
        private List<Comparable> datos = new List<Comparable>();
        private IOrdenEnAula1 ordenInicio;
        private IOrdenEnAula2 ordenLlegaAlumno;
        private IOrdenEnAula1 ordenAulaLlena;

        public void encolar(Comparable elem)
        {
            this.datos.Add(elem);
            if (this.cuantos() == 1 && this.ordenInicio != null)
            {
                this.ordenInicio.ejecutar();
            }

            if (this.ordenLlegaAlumno != null)
            {
                this.ordenLlegaAlumno.ejecutar(elem);
            }

            if (this.cuantos() == 40 && this.ordenAulaLlena != null)
            {
                this.ordenAulaLlena.ejecutar();
            }
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
            foreach (Comparable elemento in this.datos)
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
            foreach (Comparable elemento in this.datos)
            {
                if (elemento.sosMayor(max))
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
            foreach (Comparable elemento in this.datos)
            {
                if (elemento.sosIgual(valor))
                {
                    return true;
                }
            }
            return false;
        }

        public IIterador crearIterador()
        {
            return new IteradorDeCola(this.datos);
        }

        public void setOrdenInicio(IOrdenEnAula1 orden)
        {
            this.ordenInicio = orden;
        }

        public void setOrdenLlegaAlumno(IOrdenEnAula2 orden)
        {
            this.ordenLlegaAlumno = orden;
        }

        public void setAulaLlena(IOrdenEnAula1 orden)
        {
            this.ordenAulaLlena = orden;
        }

    }
}
