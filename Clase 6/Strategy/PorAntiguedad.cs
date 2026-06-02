using System;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Interfaces;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Models;

namespace Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Strategy
{
	/// <summary>
	/// Description of PorAntiguedad.
	/// </summary>
	public class PorAntiguedad : IEstrategia
	{
		public bool comparar(Comparable c1, Comparable c2){
			return ((Profesor)c1).getAntiguedad() > ((Profesor)c2).getAntiguedad();
		}
	}
}