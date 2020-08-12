using System;

namespace _09_ciclos_simulacro_02_casa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatoria = new Random();
            int total = 0, dado = 0, vidas = 3, perderV = 0, ganarV = 0, dadoT = 0;
            Console.WriteLine("¿Desea empezar el juego? s/n");
            string respuesta = Console.ReadLine();
            while (respuesta == "s")
            {
                dado = aleatoria.Next(1, 7);
                total += dado;
                perderV++;
                ganarV++;
                Console.WriteLine("su dado es: " + dado + " y su total: " + total);
                if (perderV == 2) {
                    vidas--;
                    Console.WriteLine("Acaba de perder una vida, usted queda con " + vidas + " vidas");
                    perderV = 0;
                }
                if (ganarV == 3)
                {
                    dadoT = aleatoria.Next(1, 7);
                    if (dado == dadoT)
                    {
                        Console.WriteLine("Acaba de sacar dados iguales: usted gana una vida");
                        vidas++;
                    }
                    Console.WriteLine("su segundo dado es: " + dadoT + " y su  nuevo total es: " + total);
                }
                if (total > 100)
                {
                    Console.WriteLine("\n \n Usted Gano\n \n ");
                    break;
                }
                if (vidas == 0)
                {
                    Console.WriteLine("Usted acabe de perder :c");
                    break;
                }
                Console.WriteLine("\n \n ¿Desea continuar? \n \n ");
                respuesta = Console.ReadLine();
            }
            Console.WriteLine("Su total quedo en: "+total);
        }
    }
}
