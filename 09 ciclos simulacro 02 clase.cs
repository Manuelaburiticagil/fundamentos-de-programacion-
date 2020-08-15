using System;

namespace _09_Ciclos_simulacro_02_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado = 0, total = 0, vidas = 3, i = 0, j = 0, dadosEspeciales = 2;
            string respuestaEspecial = " ";
            Console.WriteLine("¿Desea comenzar a jugar? s/n");
            string respuesta = Console.ReadLine();
            while (respuesta == "s" && (0 < vidas && vidas < 4))
            {
                dado = aleatorio.Next(1, 7);
                if (dadosEspeciales > 0)
                {
                    Console.WriteLine("¿Desea usar los dados especiales? s/n");
                    respuestaEspecial = Console.ReadLine();
                    while (respuestaEspecial != "s" && respuestaEspecial != "n")
                    {
                        Console.WriteLine("Su respuesta no es valida, porfavor ingrese de nuevo su respuesta");
                        respuestaEspecial = Console.ReadLine();
                    }
                }
                if (respuestaEspecial == "s")
                {
                    dado = aleatorio.Next(1, 13);
                    dadosEspeciales--;
                    respuestaEspecial = "n";
                }
                total += dado;
                if (dado == 1) i++;
                if (i == 2)
                {
                    vidas -= 1;
                    Console.WriteLine("\n \n Perdiste una vida \n \nse resta 10 a tu total, ahora tienes " + vidas + " vidas");
                    total -= 10;
                    i = 0;
                }
                if (dado == 6 && j == 1)
                {
                    Console.WriteLine("Obtuvo dos 6 consecutivos, tiene una vida adicional (max 3 vidas)");
                    if (vidas < 3) vidas++;
                }
                if (dado == 6) j++;
                else j = 0;
                if (vidas == 0)
                {
                    Console.WriteLine("Te quedaste sin vida :c, pierdes");
                    break;
                }
                if (respuesta == "n") break;
                if (total >= 100)
                {
                    Console.WriteLine("\n \n \n Ganaste el juego");
                    break;
                }
                Console.WriteLine("su dado es: " + dado + " y su total es: " + total);
                Console.WriteLine("\n \n \n ¿Desea continuar tirando? s/n");
                respuesta = Console.ReadLine();
                while (respuesta != "s" && respuesta != "n")
                {
                    Console.WriteLine("Su respuesta no es valida, porfavor ingrese de nuevo su respuesta");
                    respuestaEspecial = Console.ReadLine();
                }
            }
            Console.WriteLine("su total quedo en:" + total);
        }
    }
}
