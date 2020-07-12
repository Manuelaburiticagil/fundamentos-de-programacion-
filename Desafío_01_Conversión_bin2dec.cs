using System;

namespace Desafío_01_Conversión_bin2dec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su numero binario");
            int b4 = int.Parse(Console.ReadLine());
            int b3 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int b0 = int.Parse(Console.ReadLine());

            double Ob0 = b0 * Math.Pow(2, 0);
            double Ob1 = b1 * Math.Pow(2, 1);
            double Ob2 = b2 * Math.Pow(2, 2);
            double Ob3 = b3 * Math.Pow(2, 3);
            double Ob4 = b4 * Math.Pow(2, 4);

            double dec = Ob0 + Ob1 + Ob2 + Ob3 + Ob4;
            Console.WriteLine("el número ingresado, en decimal es = " + dec);
        }
    }
}
