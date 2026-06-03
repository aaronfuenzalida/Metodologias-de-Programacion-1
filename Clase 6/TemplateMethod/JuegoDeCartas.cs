using System.Collections.Generic;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Models;

namespace Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.TemplateMethod
{
    public abstract class JuegoDeCartas
    {
        protected List<string> cartasPalo = new List<string>() { "Copa", "Basto", "Espada", "Oro" };
        protected List<string> cartasNumero = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };

        protected Persona jugador1;
        protected Persona jugador2;

        public Persona jugar(Persona p1, Persona p2)
        {
            this.jugador1 = p1;
            this.jugador2 = p2;
            
            int puntosJ1 = 0;
            int puntosJ2 = 0;
            int manosJugadas = 1;

            Console.WriteLine($"\n=== INICIO DE LA PARTIDA: {p1.getNombre()} VS {p2.getNombre()} ===");

            // El juego se repite hasta que alguien llegue a 3 puntos
            while (puntosJ1 < 3 && puntosJ2 < 3)
            {
                Console.WriteLine($"\n--- MANO {manosJugadas} ---");
                
                this.mezclarMazo();
                this.repartirCartas();
                this.tomarCartas();
                this.jugarMano();
                this.descartarCartas();
                
                Persona ganadorMano = this.determinarGanador();
                
                if (ganadorMano == this.jugador1)
                {
                    puntosJ1++;
                }
                else 
                {
                    puntosJ2++;
                }

                Console.WriteLine($"-> PUNTAJE PARCIAL: {this.jugador1.getNombre()} [{puntosJ1}] - [{puntosJ2}] {this.jugador2.getNombre()}");
                manosJugadas++;
            }

            if (puntosJ1 >= 3)
            {
                return this.jugador1;
            }
            else
            {
                return this.jugador2;
            }
        }

        protected abstract void mezclarMazo();
        protected abstract void repartirCartas();
        protected abstract void jugarMano();
        protected abstract void tomarCartas();
        protected abstract void descartarCartas();   
        protected abstract Persona determinarGanador(); 
    }
}