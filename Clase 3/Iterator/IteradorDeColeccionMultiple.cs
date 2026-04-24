namespace Clase_3_Factory__Observer
{
    public class IteradorDeColeccionMultiple : IIterador
    {
        private IIterador iteradorPila;
        private IIterador iteradorCola;

        public IteradorDeColeccionMultiple(ColeccionMultiple coleccion)
        {
            this.iteradorPila = ((IIterable)coleccion.getPila()).crearIterador();
            this.iteradorCola = ((IIterable)coleccion.getCola()).crearIterador();
        }

        public void primero()
        {
            this.iteradorPila.primero();
            this.iteradorCola.primero();
        }

        public void siguiente()
        {
            if (!this.iteradorPila.fin())
            {
                this.iteradorPila.siguiente();
            }
            else
            {
                this.iteradorCola.siguiente();
            }
    }
        

        public bool fin()
        {
            return this.iteradorPila.fin() && this.iteradorCola.fin();
           
        }

        public Comparable actual()
        {
            if (!this.iteradorPila.fin())
            {
                return this.iteradorPila.actual();
            }
            else
            {
                return this.iteradorCola.actual();
            }

        }
    }
}