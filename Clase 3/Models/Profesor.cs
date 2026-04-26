using Metodologias_de_Programacion.Clase_3_Factory__Observer.Interfaces;
using Metodologias_de_Programacion.Clase_3_Factory__Observer.Strategy;

namespace Metodologias_de_Programacion.Clase_3_Factory__Observer.Models
{
    public class Profesor : Persona
    {
        private int antiguedad;
        private IEstrategia estrategia;

        public Profesor(string n,int d,int a) : base(n,d)
        {
            this.antiguedad = a;
            this.estrategia = new PorDni();
        }

        public void cambiarEstrategia(IEstrategia nEstrategia){
		    this.estrategia = nEstrategia;
		}

        public void hablarALaClase()
        {
            Console.WriteLine("Hablando de algún tema");
        }

        public void escribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarrón");
        }

        public int getAntiguedad()
        {
            return this.antiguedad;
        }

        public override bool sosIgual(Comparable persona) => !this.sosMenor(persona) && !this.sosMayor(persona);

		public override bool sosMenor(Comparable persona) => estrategia.comparar((Profesor)persona, this);

		public override bool sosMayor(Comparable persona) => estrategia.comparar(this, (Profesor)persona);
    }

}