using System;

namespace Desafío_02_cálculo_de_cuota_moderada
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
                Console.WriteLine("usted tiene tarifa A y su cuota moderadora es $3.400");
            }
            else if (2 * smmlv <= salario && salario < smmlv * 5)
            {
                Console.WriteLine("usted tiene tarifa B y su cuota moderadora es $13.500");
            }
            else
            {
                Console.WriteLine("usted tiene tarifa C y su cuota moderadora es $35.600");
            }
        }
    }
    }
}
