/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 16:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Clase_3_Factory__Observer
{
	/// <summary>
	/// Description of PorNombre.
	/// </summary>
	public class PorNombre : IEstrategia
	{
		public bool comparar(Alumno a1, Alumno a2){
			return a1.getNombre().Length > a2.getNombre().Length;
			}
		}
	}

