using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Strategy;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Models
{
    public class Profesor : Persona , IObservado
    {
        private int antiguedad;
        private bool hablando;
        private IEstrategia estrategia;
        private List<IObservador> observadores = new List<IObservador>();

        public Profesor(string n,int d,int a) : base(n,d)
        {
            this.antiguedad = a;
            this.estrategia = new PorDni();
            this.hablando = false;
        }

        public void cambiarEstrategia(IEstrategia nEstrategia){
		    this.estrategia = nEstrategia;
		}

        public void hablarALaClase()
        {
            this.hablando = true;
            Console.WriteLine("----- Hablando de algún tema -----");
            this.notificar();
        }

        public bool estaHablando()
        {
            return this.hablando;
        }

        public void escribirEnElPizarron()
        {
            this.hablando = false;
            Console.WriteLine("----- Escribiendo en el pizarrón -----");
            notificar();
        }

        public int getAntiguedad()
        {
            return this.antiguedad;
        }

        public override bool sosIgual(Comparable persona) => !this.sosMenor(persona) && !this.sosMayor(persona);

		public override bool sosMenor(Comparable persona) => estrategia.comparar((Profesor)persona, this);

		public override bool sosMayor(Comparable persona) => estrategia.comparar(this, (Profesor)persona);

        public void agregarObservador(IObservador o)
        {
            observadores.Add(o);
        }

        public void quitarObservador(IObservador o)
        {
            observadores.Remove(o);
        }

        public void notificar()
        {
            foreach (IObservador o in observadores)
            {
                o.actualizar(this);
            }
        }
    }

}