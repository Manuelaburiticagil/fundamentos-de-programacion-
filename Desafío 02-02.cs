using System;

namespace Desafío_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese z");
            double z = double.Parse(Console.ReadLine());

            //hallar t 

            double t = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2));
            Console.WriteLine("valor de t = "+ t );

            // hallar a y c
            
            double aRad = Math.Acos(z / t);
            double cRad = Math.Acos(y / t);
            double a = aRad * (180 / Math.PI);
            double c = cRad * (180 / Math.PI);
            Console.WriteLine("valor de a = "+ a);
            Console.WriteLine("valor de c = " + c);
        }
    }
}
