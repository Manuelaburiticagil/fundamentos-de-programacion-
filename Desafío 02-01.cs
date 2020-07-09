using System;

namespace Desafío_02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese T");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese a");
            double aGrados = double.Parse(Console.ReadLine());

            // hallar c

            double cGrados = 180 - 90 - aGrados;
            Console.WriteLine("valor c = "+ cGrados );

            // Convertir a Rad

            double a = aGrados * (Math.PI / 180);
            double c = cGrados * (Math.PI / 180);

            //hallar y

            double y = Math.Sin(a) * t;
            Console.WriteLine("valor y = "+y);

            //hallar z

            double z = Math.Cos(a) * t;
            Console.WriteLine("valor z ="+z);

        }
    }
}
