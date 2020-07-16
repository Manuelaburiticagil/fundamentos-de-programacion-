using System;

namespace Desafío_01_cálculo_de_tarifa__contexto_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario mensual");
            double salario = double.Parse(Console.ReadLine());
            double smmlv = 877803;
            if (salario < smmlv * 2)
            {
                Console.WriteLine("usted tiene tarifa A");
            }
            else if (2 * smmlv <= salario && salario < smmlv * 4)
            {
                Console.WriteLine("usted tiene tarifa B");
            }
            else
            {
                Console.WriteLine("usted tiene tarifa C");
            }
        }
    }
}
