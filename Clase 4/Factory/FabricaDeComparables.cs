using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Factory
{
public abstract class FabricaDeComparables
{
    public static Comparable CrearAleatorio(string opcion)
    {
        FabricaDeComparables fabrica;
        switch (opcion)
        {
            case "Numero":
                fabrica = new FabricaDeNumeros();
                fabrica.setAleatorioON();
                break;
            case "Alumno":
                fabrica= new FabricaDeAlumnos();
                fabrica.setAleatorioON();
                break;
            case "Profesor":
                fabrica = new FabricaDeProfesores();
                fabrica.setAleatorioON();
                break;
            default:
                throw new ArgumentException("Opcion no valida");
        }

        return fabrica.crearComparable();
    }

    public static Comparable CrearPorTeclado(string opcion)
    {
        FabricaDeComparables fabrica;
        switch (opcion)
        {
            case "Numero":
                fabrica = new FabricaDeNumeros();
                break;
            case "Alumno":
                fabrica = new FabricaDeAlumnos();
                break;
            case "Profesor":
                fabrica = new FabricaDeProfesores();
                break;
            default:
                throw new ArgumentException("Opcion no valida");
        }

        return fabrica.crearComparable();
    }

    public abstract Comparable crearComparable();

    public abstract void setAleatorioON();
    public abstract void setAleatorioOFF();
    }
}