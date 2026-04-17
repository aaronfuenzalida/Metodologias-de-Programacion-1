/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Clase_2___Strategy___Iterator
{
	/// <summary>
	/// Description of Estrategia.
	/// </summary>
	public interface IEstrategia
	{
		bool comparar(Alumno alumno1, Alumno alumno2);
	}
}
