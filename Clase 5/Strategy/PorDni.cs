/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 16:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Interfaces;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Models;

namespace Metodologias_de_Programacion.Clase_5_Proxy__Command.Strategy
{
	/// <summary>
	/// Description of PorDni.
	/// </summary>
	public class PorDni : IEstrategia
	{
		public bool comparar(Comparable c1, Comparable c2){
			return ((IPersona)c1).getDni() > ((IPersona)c2).getDni();
		}
	}
}
