using System;

namespace BlackJack_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos jugadores son: (máximo 5, mínimo 2)");
            int jugadores = int.Parse(Console.ReadLine());
            while (jugadores<2 ||jugadores>5)
            {
                Console.WriteLine("Respuesta no valida, los jugadores tienen que ser máximo 5 y mínimo 2, Ingrese de nuevo su respuesta");
                jugadores = int.Parse(Console.ReadLine());
            }
            int contadorJ = 0, max = 0, ganador = 0;
            while (contadorJ < jugadores)
            {
                Random aleatorio = new Random();
                Console.WriteLine("\n \n \n Empieza el jugador " + (contadorJ + 1));
                contadorJ++;
                int carta = 0, carta1 = aleatorio.Next(1, 11), carta2 = aleatorio.Next(1, 11), total = carta1 + carta2;
                Console.WriteLine("sus cartas iniciales son: " + carta1 + " y " + carta2 + " y su total es: " + total);
                string respuesta = "s";
                while (total < 21 && respuesta == "s")
                {
                    Console.WriteLine("\n ¿desea continuar? s/n");
                    respuesta = Console.ReadLine();
                    while (respuesta != "s" && respuesta != "n")
                    {
                        Console.WriteLine("Respuesta no valida, porfavor ingrese de nuevo su respuesta: s/n");
                        respuesta = Console.ReadLine();
                    }
                    if (respuesta == "n") break;
                    else
                    {
                        carta = aleatorio.Next(1, 11);
                        total += carta;
                        Console.WriteLine("su nueva carta es: " + carta + " y su nuevo total es: " + total);
                    }
                }
                if (total <= 21)
                {
                    Console.WriteLine("Termino el juego con un total de: " + total);
                }
                else
                {
                    Console.WriteLine("Queda eliminado, con un total de: " + total);
                }
                if (total > max && total < 22)
                {
                    max = total;
                    ganador = contadorJ;
                }
            }
            Console.WriteLine("\n \n \n \n El ganador fue el jugador " + ganador + " con un total de: " + max);
        }
    }
}
