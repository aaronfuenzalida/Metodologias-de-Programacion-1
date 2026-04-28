/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 17/4/2026
 * Time: 16:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces
{
	/// <summary>
	/// Description of IIterable.
	/// </summary>
	public interface IIterable
	{
		IIterador crearIterador();
	}
}
