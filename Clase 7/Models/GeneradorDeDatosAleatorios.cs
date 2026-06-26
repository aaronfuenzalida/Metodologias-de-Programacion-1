namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models
{
    public class GeneradorDeDatosAleatorios : ManejadorObtencionDatos
    {
        private static GeneradorDeDatosAleatorios unicaInstancia;
        private Random random;

        // Constructor privado por Singleton
        private GeneradorDeDatosAleatorios()
        {
            random = new Random();
        }

        public static GeneradorDeDatosAleatorios GetInstance()
        {
            if (unicaInstancia == null)
            {
                unicaInstancia = new GeneradorDeDatosAleatorios();
            }
            return unicaInstancia;
        }

        public override int numero(int max, int opcion)
        {
            if (opcion == 1) // Atiende Aleatorio
            {
                return random.Next(0, max + 1);
            }
            else if (sucesor != null)
            {
                return sucesor.numero(max, opcion); // Pasa al siguiente
            }
            return 0;
        }

        public override string cadena(int cant, int opcion)
        {
            if (opcion == 1)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, cant)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            else if (sucesor != null)
            {
                return sucesor.cadena(cant, opcion);
            }
            return "";
        }
    }
}
