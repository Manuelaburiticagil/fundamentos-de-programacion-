using System;

namespace Desafío_2_solución_de_la_ecuación_cuadrática
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresa b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresa c");
            double c = double.Parse(Console.ReadLine());

            double discriminante = Math.Pow(b, 2) - (4 * a * c);
            double respuestaP = 0;
            double respuestaN = 0;

            if (discriminante == 0) {
                respuestaP = (-b) / (2 * a);
                Console.WriteLine("unica solución, x=" + respuestaP);   
            }
            else if (discriminante > 0){
                respuestaP = (-b + Math.Sqrt(discriminante)) / (2 * a);
                respuestaN = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine("dos popdibles soluciones, x1=" + respuestaP + " x2=" + respuestaN);
            }
            else {
                Console.WriteLine("no es posible solución en los Reales");
            }
        }
    }
}
