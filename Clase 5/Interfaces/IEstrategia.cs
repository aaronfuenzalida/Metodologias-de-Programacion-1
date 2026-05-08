/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Models;

namespace Metodologias_de_Programacion.Clase_5_Proxy__Command.Interfaces
{
	/// <summary>
	/// Description of Estrategia.
	/// </summary>
	public interface IEstrategia
	{
		bool comparar(Comparable c1, Comparable c2);
	}
}
