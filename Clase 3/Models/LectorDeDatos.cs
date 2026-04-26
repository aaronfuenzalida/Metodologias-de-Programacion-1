namespace Metodologias_de_Programacion.Clase_3_Factory__Observer.Models
{
public class LectorDeDatos
{
    public int numeroPorTeclado()
    {
        Console.WriteLine("Ingrese un numero: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public string stringPorTeclado()
    {
        Console.WriteLine("Ingrese un string: ");
        return Console.ReadLine();
    }

}
}