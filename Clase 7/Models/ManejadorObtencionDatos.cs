namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models
{
    public abstract class ManejadorObtencionDatos
    {
        protected ManejadorObtencionDatos sucesor;

        public void setSucesor(ManejadorObtencionDatos sucesor)
        {
            this.sucesor = sucesor;
        }

        // 1 = Aleatorio, 2 = Teclado, 3 = Archivo
        public abstract int numero(int max, int opcion);
        public abstract string cadena(int cant, int opcion);
    }
}