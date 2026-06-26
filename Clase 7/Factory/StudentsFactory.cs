using System.Collections;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Decorator;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Adapter;
using Microsoft.VisualBasic;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Factory
{
    public class StudentsFactory : FabricaDeAlumnos
    {
        public Student studentDecoration()
        {
            Comparable alumno = base.crearComparable();

            IAlumno dec= new DecoradorLegajo((IAlumno)alumno);
            dec = new DecoradorNotaEstado(dec);
            dec = new DecoradorNotaLetras(dec);
            dec = new DecoradorCuadro(dec);

            return new AlumnoAdapter(dec);
        }
    }

}
