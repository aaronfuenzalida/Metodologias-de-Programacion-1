
namespace Clase_3_Factory__Observer
{
    
    public class IteradorDePila : IIterador
    {
        private List<Comparable> datos;
        private int indiceActual;

        public IteradorDePila(List<Comparable> elementos)
        {
            this.datos=elementos;
            this.primero();
        }

        public void primero()
        {
            this.indiceActual = this.datos.Count - 1;
        }

        public void siguiente()
        {
            this.indiceActual--;
        }

        public bool fin()
        {
            return this.indiceActual < 0;

        }

        public Comparable actual()
        {
            return this.datos[this.indiceActual];
        }
    }
}