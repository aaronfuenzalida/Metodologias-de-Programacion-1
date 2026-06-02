using System;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Interfaces;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Models;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Composite;

namespace Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Factory{
    public class FabricaDeAlumnosCompuestos : FabricaDeComparables
    {
        protected bool aleatorio = false;

        public override Comparable crearComparable()
        {
            AlumnoCompuesto grupo = new AlumnoCompuesto();

            if (this.aleatorio)
            {
                for (int i = 0; i < 5; i++)
                {
                    IAlumno alumnoRandom = (IAlumno)FabricaDeComparables.CrearAleatorio("Alumno");
                    grupo.agregarAlumno(alumnoRandom);
                }
            }

            return grupo;
        }

        public override void setAleatorioON()
        {
            aleatorio = true;
        }

        public override void setAleatorioOFF()
        {
            aleatorio = false;
        }
    }
}