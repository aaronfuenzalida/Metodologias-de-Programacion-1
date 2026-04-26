using Metodologias_de_Programacion.Clase_3_Factory__Observer.Interfaces;
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Models;

namespace Metodologias_de_Programacion.Clase_3_Factory__Observer.Factory
{
    public class FabricaDeProfesores : FabricaDeComparables
    {
        private bool aleatorio = false;
        public override Comparable crearComparable()
        {
            if (aleatorio)
            {
                GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
                return new Profesor(generador.stringAleatorio(10), generador.numeroAleatorio(100000), generador.numeroAleatorio(50));
            }
            else
            {
                LectorDeDatos lector = new LectorDeDatos();
                Console.Write("Ingrese el nombre del profesor: ");
                string nombre = lector.stringPorTeclado();
                Console.Write("Ingrese el dni del profesor: ");
                int dni = lector.numeroPorTeclado();
                Console.Write("Ingrese la antiguedad del profesor: ");
                int antiguedad = lector.numeroPorTeclado();
                return new Profesor(nombre, dni, antiguedad);
            }
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