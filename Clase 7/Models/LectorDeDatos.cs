namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models
{
    public class LectorDeDatos : ManejadorObtencionDatos
    {
        public override int numero(int max, int opcion)
        {
            if (opcion == 2) // Atiende Teclado
            {
                Console.Write("Ingrese un numero: ");
                return Convert.ToInt32(Console.ReadLine());
            }
            else if (sucesor != null)
            {
                return sucesor.numero(max, opcion);
            }
            return 0;
        }

        public override string cadena(int cant, int opcion)
        {
            if (opcion == 2)
            {
                Console.Write("Ingrese un string: ");
                return Console.ReadLine();
            }
            else if (sucesor != null)
            {
                return sucesor.cadena(cant, opcion);
            }
            return "";
        }
    }
}
