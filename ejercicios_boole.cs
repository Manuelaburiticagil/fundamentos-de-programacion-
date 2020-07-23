using System;

namespace ejercicios_boole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese votos por partido a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese votos por partido b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese votos blancos");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el total de la población");
            int totalPoblación = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el porcentaje de la población mayor de edad");
            double porcentajeMayor = double.Parse(Console.ReadLine());

            int votantes = a + b + blancos + anulados;
            int abstención = (int)(((porcentajeMayor /100) * totalPoblación)-votantes);

            bool A = anulados < 0.3 * (a + b);
            bool B = (a + b) > blancos;
            bool C = abstención < votantes;

            if ((A || B) && C)
            {
                Console.WriteLine("las votaciones fueron exitosas");
                if (a > b) Console.WriteLine("el partido ganador es a");
                else Console.WriteLine("el partido ganador es b");
            }
            else Console.WriteLine(" las elecciones deben ser realizadas nuevamente");

        }
    }
}
