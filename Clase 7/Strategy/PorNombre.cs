/*
 * Created by SharpDevelop.
 * User: Aaron
 * Date: 16/4/2026
 * Time: 16:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Strategy
{
    /// <summary>
    /// Description of PorNombre.
    /// </summary>
    public class PorNombre : IEstrategia
    {
        public bool comparar(Comparable c1, Comparable c2)
        {
            return ((IPersona)c1).getNombre().Length > ((IPersona)c2).getNombre().Length;
        }
    }
}

