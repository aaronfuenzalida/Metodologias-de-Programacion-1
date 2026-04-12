/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 9/4/2026
 * Time: 16:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Clase_1
{

	public interface IColeccionable
	{
		int cuantos();
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable comparable);
		bool contiene(Comparable comparable);
	}
}
