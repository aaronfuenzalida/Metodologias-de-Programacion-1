/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 17/4/2026
 * Time: 16:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Clase_2___Strategy___Iterator
{
	/// <summary>
	/// Description of IIterador.
	/// </summary>
	public interface IIterador
	{
		void primero();
		void siguiente();
		bool fin();
		Comparable actual();
	}
}
