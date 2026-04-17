/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 16:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Clase_2___Strategy___Iterator
{
	/// <summary>
	/// Description of Comparable.
	/// </summary>
	public interface Comparable
	{
		bool sosIgual(Comparable valor);
		bool sosMenor(Comparable valor);
		bool sosMayor(Comparable valor);
		
	}
}
