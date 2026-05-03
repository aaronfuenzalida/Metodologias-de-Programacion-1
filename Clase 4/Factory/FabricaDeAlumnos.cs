using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Models;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Factory
{
public class FabricaDeAlumnos : FabricaDeComparables
{
    protected bool aleatorio = false;
    public override Comparable crearComparable()
    {
        if (aleatorio)
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            return new Alumno(generador.stringAleatorio(10), generador.numeroAleatorio(100000), generador.numeroAleatorio(10), generador.numeroAleatorio(100));
        }
        else
        {
            LectorDeDatos lector = new LectorDeDatos();
            Console.Write("Ingrese el nombre del alumno");
            string nombre = lector.stringPorTeclado();
            Console.Write("Ingrese el dni del alumno: ");
            int dni = lector.numeroPorTeclado();
            Console.Write("Ingrese el legajo: ");
            int legajo = lector.numeroPorTeclado();
            Console.Write("Ingrese el promedio del alumno: ");
            int promedio = lector.numeroPorTeclado();
            return new Alumno(nombre, dni, legajo, promedio);
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