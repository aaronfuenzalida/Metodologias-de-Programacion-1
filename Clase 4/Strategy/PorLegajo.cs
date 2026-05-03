/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 16:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Models;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Strategy
{
	/// <summary>
	/// Description of PorLegajo.
	/// </summary>
	public class PorLegajo : IEstrategia
	{
		public bool comparar(Comparable c1, Comparable c2){
			return ((IAlumno)c1).getLegajo() > ((IAlumno)c2).getLegajo();
		}
	}
}
