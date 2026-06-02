using System.Collections;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Interfaces;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Models;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Decorator;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Adapter;
using Microsoft.VisualBasic;

namespace Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Factory
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