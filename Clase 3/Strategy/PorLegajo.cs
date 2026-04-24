/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 16:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Clase_3_Factory__Observer
{
	/// <summary>
	/// Description of PorLegajo.
	/// </summary>
	public class PorLegajo : IEstrategia
	{
		public bool comparar(Alumno a1, Alumno a2){
			return a1.getLegajo() > a2.getLegajo();
		}
	}
}
