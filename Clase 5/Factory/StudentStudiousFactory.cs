using Metodologias_de_Programacion.Clase_5_Proxy__Command.Interfaces;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Models;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Decorator;
using Metodologias_de_Programacion.Clase_5_Proxy__Command.Adapter;

namespace Metodologias_de_Programacion.Clase_5_Proxy__Command.Factory
{
    public class StudentStudiousFactory : FabricaDeAlumnosEstudiosos 
    {
        public Student StudentStudiousDecoration()
        {
            Comparable alumno = base.crearComparable();

            IAlumno dec = new DecoradorLegajo((IAlumno)alumno);
            dec = new DecoradorNotaEstado(dec);
            dec = new DecoradorNotaLetras(dec);
            dec = new DecoradorCuadro(dec);

            return new AlumnoAdapter(dec);
        }
    }
}