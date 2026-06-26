/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 16:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Strategy
{
    /// <summary>
    /// Description of PorPromedio.
    /// </summary>
    public class PorPromedio : IEstrategia
    {
        public bool comparar(Comparable c1, Comparable c2)
        {
            return ((IAlumno)c1).getPromedio() > ((IAlumno)c2).getPromedio();
        }
    }
}
