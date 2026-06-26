using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Interfaces;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Factory
{
    public abstract class FabricaDeComparables
    {
        protected ManejadorObtencionDatos manejador;
        protected int opcionActual; 

        public FabricaDeComparables()
        {
            GeneradorDeDatosAleatorios random = GeneradorDeDatosAleatorios.GetInstance();
            LectorDeDatos teclado = new LectorDeDatos();
            LectorDeArchivos archivo = LectorDeArchivos.GetInstance();

            random.setSucesor(teclado);
            teclado.setSucesor(archivo);

            this.manejador = random;
        }

        public static Comparable CrearAleatorio(string tipo)
        {
            FabricaDeComparables fabrica = ObtenerFabrica(tipo);
            fabrica.opcionActual = 1; 
            return fabrica.crearComparable();
        }

        public static Comparable CrearPorTeclado(string tipo)
        {
            FabricaDeComparables fabrica = ObtenerFabrica(tipo);
            fabrica.opcionActual = 2; 
            return fabrica.crearComparable();
        }

        public static Comparable CrearDesdeArchivo(string tipo)
        {
            FabricaDeComparables fabrica = ObtenerFabrica(tipo);
            fabrica.opcionActual = 3; 
            return fabrica.crearComparable();
        }

        private static FabricaDeComparables ObtenerFabrica(string tipo)
        {
            switch (tipo)
            {
                case "Numero": return new FabricaDeNumeros();
                case "Alumno": return new FabricaDeAlumnos();
                case "Profesor": return new FabricaDeProfesores();
                case "AlumnoEstudioso": return new FabricaDeAlumnosEstudiosos();
                case "AlumnoCompuesto": return new FabricaDeAlumnosCompuestos();
                default: throw new ArgumentException("Opcion no valida");
            }
        }

        public abstract Comparable crearComparable();

        public virtual void setAleatorioON() { opcionActual = 1; }
        public virtual void setAleatorioOFF() { opcionActual = 2; }
    }
}
