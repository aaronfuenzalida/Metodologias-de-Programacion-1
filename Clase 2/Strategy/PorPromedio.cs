/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 16:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Clase_2___Strategy___Iterator
{
	/// <summary>
	/// Description of PorPromedio.
	/// </summary>
	public class PorPromedio : IEstrategia
	{
		public bool comparar(Alumno a1, Alumno a2){
			return a1.getPromedio() > a2.getPromedio();
		}
	}
}
