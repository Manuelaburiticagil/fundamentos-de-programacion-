using System;
using System.Xml.Schema;

namespace Desafío_01_Implementar_el_juego_Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, carta1 = aleatorio.Next(1, 11), carta2 = aleatorio.Next(1, 11), total = carta1 + carta2;
            Console.WriteLine("sus cartas iniciales son: " + carta1 + " y " + carta2+" y su total es: "+total);
            string respuesta = "si";
            while (total < 22 && respuesta=="si") {
                Console.WriteLine("¿desea continuar? si/no");
                respuesta = Console.ReadLine();
                switch (respuesta) { 
                    case "si":
                        carta = aleatorio.Next(1, 11);
                        total += carta;
                        Console.WriteLine("su nueva carta es: " + carta + " y su nuevo total es: " + total);
                    case "no":
                        break;
                }
            }
            if (total<22){
                Console.WriteLine("Termino el juego con un total de: " + total);
            }
            else{
                Console.WriteLine("Queda eliminado, con un total de: " + total);
            }
        }
    }
}
