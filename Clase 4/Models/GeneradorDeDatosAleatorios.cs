namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Models
{
public class GeneradorDeDatosAleatorios
{
    public int numeroAleatorio(int max)
    {
        Random random = new Random();
        return random.Next(0,max+1); 
    }

    public string stringAleatorio(int cant)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random random = new Random();
        return new string(Enumerable.Repeat(chars, cant)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }
    
}
}