using System;

namespace Desafío_02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese c");
            double cGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese z");
            double z = double.Parse(Console.ReadLine());

            //hallar a

            double aGrados = 180 - 90 - cGrados;
            Console.WriteLine("valor de a = "+ aGrados);

            //convertir

            double c = cGrados * (Math.PI / 180);
            double a = aGrados * (Math.PI / 180);

            //hallar y y t

            double y = z / Math.Tan(c);
            double t = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2));
            Console.WriteLine("valor de y = "+ y);
            Console.WriteLine("valor de t = "+ t);
        }
    }
}
