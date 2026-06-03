using System;
using Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.Models;

namespace Metodologias_de_Programacion.Clase_6_Composite__TemplateMethod.TemplateMethod
{
    public class CartaBomba : JuegoDeCartas
    {
        private bool bombaJugador1 = false;
        private bool bombaJugador2 = false;
        private Random random = new Random();

        override protected void mezclarMazo() => Console.WriteLine("\nMezclando el mazo (estilo americana) de cartas bomba...");
        override protected void repartirCartas() => Console.WriteLine("Repartiendo 4 cartas bomba...");
        override protected void tomarCartas() => Console.WriteLine("Tomando las 4 cartas bomba...\n");

        override protected void jugarMano()
        {
            int ronda = 1;

            // Para no hacer el juego eterno, se fuerza el final a la ronda 3
            while (!bombaJugador1 && !bombaJugador2 && ronda <= 3)
            {
                Console.WriteLine($"\n--- Ronda {ronda} ---");

                if (ronda == 3)
                {
                    Console.WriteLine("¡El mazo se agota! Esta ronda es definitiva...");
                    Console.Write($"{this.jugador1.getNombre()} tome una carta (Pulse una tecla)");
                    Console.ReadKey();
                    Console.WriteLine($"\n{this.jugador1.getNombre()} saca el 4 de Copa. Se salva!");

                    Console.Write($"{this.jugador2.getNombre()} tome una carta (Pulse una tecla)");
                    Console.ReadKey();
                    Console.WriteLine($"\n¡OH NO! {this.jugador2.getNombre()} ha sacado el 1 de Oro. ¡BOOM!");
                    bombaJugador2 = true;
                    break;
                }

                // Turno Jugador 1
                Console.Write($"{this.jugador1.getNombre()} tome una carta (Pulse una tecla)");
                Console.ReadKey();

                int indicePalo = random.Next(cartasPalo.Count);
                int indiceNumero = random.Next(cartasNumero.Count);
                string paloSacado = cartasPalo[indicePalo];
                string numeroSacado = cartasNumero[indiceNumero];

                if (paloSacado == "Oro" && numeroSacado == "1")
                {
                    bombaJugador1 = true;
                    Console.WriteLine($"\n¡{this.jugador1.getNombre()} ha sacado el {numeroSacado} de {paloSacado} (CARTA BOMBA)!");
                }
                else
                {
                    Console.WriteLine($"\n{this.jugador1.getNombre()} saca el {numeroSacado} de {paloSacado}. Sigue vivo.");
                }

                // Turno Jugador 2 
                if (!bombaJugador1)
                {
                    Console.Write($"{this.jugador2.getNombre()} tome una carta (Pulse una tecla)");
                    Console.ReadKey();

                    indicePalo = random.Next(cartasPalo.Count);
                    indiceNumero = random.Next(cartasNumero.Count);
                    paloSacado = cartasPalo[indicePalo];
                    numeroSacado = cartasNumero[indiceNumero];

                    if (paloSacado == "Oro" && numeroSacado == "1")
                    {
                        bombaJugador2 = true;
                        Console.WriteLine($"\n¡{this.jugador2.getNombre()} ha sacado el {numeroSacado} de {paloSacado} (CARTA BOMBA)!");
                    }
                    else
                    {
                        Console.WriteLine($"\n{this.jugador2.getNombre()} saca el {numeroSacado} de {paloSacado}. Sigue vivo.");
                    }
                }

                ronda++;
            }
        }

        override protected void descartarCartas() => Console.WriteLine("\nDescartando las cartas de la mesa...");
        
        override protected Persona determinarGanador()
        {
            if (bombaJugador1)
            {
                Console.WriteLine($"\n¡{this.jugador2.getNombre()} gana la partida!");
                return this.jugador2;
            }
            else 
            {
                Console.WriteLine($"\n¡{this.jugador1.getNombre()} gana la partida!");
                return this.jugador1;
            }
        }
    }
}