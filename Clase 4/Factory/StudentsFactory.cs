using System.Collections;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Models;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Decorator;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Adapter;
using Microsoft.VisualBasic;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Factory
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