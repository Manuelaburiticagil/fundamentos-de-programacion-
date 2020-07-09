using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese x1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese y1");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("coordenada 1 =" + " " + "(" + x1 + "," + y1 + ")");
            Console.WriteLine("ingrese x2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese y2");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("coordenada 2 =" + " " + "(" + x2 + "," + y2 + ")");

            //calcular la pendiente e intersepto 

            double m = (y2 - y1) / (x2 / x1);
            Console.WriteLine("la pendiente es =" + " " + m);
            double I = y1 - (m * x1);
            Console.WriteLine("El intercepto es =" + " " + I);

            //calcular la distancia 

            double Distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("La distancia es =" + " " + Distancia);
        }
    }
}
