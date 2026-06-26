using System;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Composite;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Factory{
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
