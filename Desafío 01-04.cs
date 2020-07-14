using System;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DESAFÍO 1");
            Console.WriteLine("ingrese b");
            double bGraddos = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese z");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese y");
            double y = double.Parse(Console.ReadLine());

            //hallar t

            double t = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(z, 2));

            //hallar a

            double a = Math.Asin(y / t);
            double b = bGraddos * (Math.PI / 180);

            //hallar x

            double x = (z * Math.Tan(a + b)) - y;
            Console.WriteLine("valor de x = " + x);

            ////////////////////////////////////////////////////////////////////

            Console.WriteLine("DESAFÍO 2");
            Console.WriteLine("ingrese d");
            double d2Grados = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese b");
            double b2Grados = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese y");
            double y2 = double.Parse(Console.ReadLine());

            //hallar e y c por ángulo suplementario

            double e2Grados = 180 - d2Grados - b2Grados;
            double c2Grados = 180 - e2Grados;
            double c2 = c2Grados * (Math.PI / 180);

            // haller z
            double z2 = y2 * Math.Tan(c2);
            Console.WriteLine("el valor de z es = " + z2);

            /////////////////////////////////////////////////////////////////

            Console.WriteLine("DESAFÍO 3");
            Console.WriteLine("ingrese w");
            double w3 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese d");
            double d3Grados = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese x");
            double x3 = double.Parse(Console.ReadLine());
            double d3 = d3Grados * (Math.PI / 180);

            //hallar t

            double t3 = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(w3, 2) - 2 * x3 * w3 * Math.Cos(d3));

            double e3 = Math.Acos((Math.Pow(w3, 2) - Math.Pow(t3, 2) - Math.Pow(x3, 2)) / (-2 * t3 * x3));
            double e3Grados = e3 * (180 / Math.PI);
            double c3Grados = 180 - e3Grados;
            double c3 = c3Grados * (Math.PI / 180);

            //hallar y

            double y3 = t3 * Math.Cos(c3);
            Console.WriteLine("el valor de y es = " + y3);

            ////////////////////////////////////////////////////////////////////

            Console.WriteLine("DESAFÍO 4");
            Console.WriteLine("ingrese w");
            double w4 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese t");
            double t4 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese c");
            double c4Grados = double.Parse(Console.ReadLine());
            double c4 = c4Grados * (Math.PI / 180);

            // hallar z

            double z4 = t4 * Math.Sin(c4);

            // hallar y 

            double y4 = Math.Sqrt(Math.Pow(t4, 2) - Math.Pow(z4, 2));

            // hallar d

            double d4 = Math.Asin(z4 / w4);
            double x4 = (Math.Sqrt(Math.Pow(w4,2)-Math.Pow(z4,2)))-y4;
            Console.WriteLine("el valor de x es = " + x4);
        }
    }
}
