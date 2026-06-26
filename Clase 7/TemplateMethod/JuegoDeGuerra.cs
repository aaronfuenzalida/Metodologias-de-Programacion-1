using System;
using Metodologias_de_Programacion.Clase_7_Chain__Singleton.Models;

namespace Metodologias_de_Programacion.Clase_7_Chain__Singleton.TemplateMethod
{
    public class JuegoDeGuerra : JuegoDeCartas
    {
        // Variables para guardar el numero de la carta que saco cada uno y poder compararlas al final
        private int valorCartaJ1;
        private int valorCartaJ2;
        private Random rnd = new Random();

        override protected void mezclarMazo() => Console.WriteLine("\nMezclando el mazo para el duelo de Guerra...");
        override protected void repartirCartas() => Console.WriteLine("Repartiendo una carta a cada jugador...");
        override protected void tomarCartas() => Console.WriteLine("Los jugadores se miran fijamente a los ojos...\n");

        override protected void jugarMano()
        {
            Console.WriteLine("Comienza la batalla");

            // Turno Jugador 1
            Console.Write($"{this.jugador1.getNombre()} tire su carta (Pulse una tecla)");
            Console.ReadKey();
            int indicePalo1 = rnd.Next(cartasPalo.Count);
            int indiceNumero1 = rnd.Next(cartasNumero.Count);
            // Convertimos el string a int para poder comparar matematicamente quien es mayor
            valorCartaJ1 = int.Parse(cartasNumero[indiceNumero1]);
            Console.WriteLine($"\n{this.jugador1.getNombre()} saca un {cartasNumero[indiceNumero1]} de {cartasPalo[indicePalo1]}.");

            // Turno Jugador 2
            Console.Write($"{this.jugador2.getNombre()} tire su carta (Pulse una tecla)");
            Console.ReadKey();
            int indicePalo2 = rnd.Next(cartasPalo.Count);
            int indiceNumero2 = rnd.Next(cartasNumero.Count);
            valorCartaJ2 = int.Parse(cartasNumero[indiceNumero2]);
            Console.WriteLine($"\n{this.jugador2.getNombre()} saca un {cartasNumero[indiceNumero2]} de {cartasPalo[indicePalo2]}.");

            // --- SISTEMA DE DESEMPATE ---
            // Si llegan a sacar el mismo número, entran en "Guerra" y tiran de nuevo
            while (valorCartaJ1 == valorCartaJ2)
            {
                Console.WriteLine("\n¡EMPATE! ¡Se declara la GUERRA! Ambos deben sacar otra carta.");

                // J1 saca de nuevo
                Console.Write($"{this.jugador1.getNombre()} tire su carta (Pulse una tecla)");
                Console.ReadKey();
                indicePalo1 = rnd.Next(cartasPalo.Count);
                indiceNumero1 = rnd.Next(cartasNumero.Count);
                valorCartaJ1 = int.Parse(cartasNumero[indiceNumero1]);
                Console.WriteLine($"\n{this.jugador1.getNombre()} saca un {cartasNumero[indiceNumero1]} de {cartasPalo[indicePalo1]}.");

                // J2 saca de nuevo
                Console.Write($"{this.jugador2.getNombre()} tire su carta (Pulse una tecla)");
                Console.ReadKey();
                indicePalo2 = rnd.Next(cartasPalo.Count);
                indiceNumero2 = rnd.Next(cartasNumero.Count);
                valorCartaJ2 = int.Parse(cartasNumero[indiceNumero2]);
                Console.WriteLine($"\n{this.jugador2.getNombre()} saca un {cartasNumero[indiceNumero2]} de {cartasPalo[indicePalo2]}.");
            }
        }

        override protected void descartarCartas() => Console.WriteLine("\nJuntando las cartas de la mesa...");

        override protected Persona determinarGanador()
        {
            // El que tenga el valor mas alto, gana
            if (valorCartaJ1 > valorCartaJ2)
            {
                Console.WriteLine($"\n{this.jugador1.getNombre()} tiene la carta mayor y gana la partida!");
                return this.jugador1;
            }
            else
            {
                Console.WriteLine($"\n{this.jugador2.getNombre()} tiene la carta mayor y gana la partida!");
                return this.jugador2;
            }
        }
    }
}
