using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su salario mensual");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su tipo de contrato, 1 si es dependiente, 2 si es independiente");
            double tipodecontrato = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su nivel de riesgo");
            double riesgo = double.Parse(Console.ReadLine());

            double smmlv = 877803, salarioReal = 0, salarioanual = 0, eps = 0, pensión = 0, arl = 0;
            double baseCotización = 0.4 * salario;
            if (baseCotización < smmlv) baseCotización = smmlv;

            if (tipodecontrato == 1)  {
                eps= 0.04 * baseCotización;
                pensión= 0.04 * baseCotización;
                salarioReal = salario - eps - pensión;
                salarioanual = (salarioReal * 12) + salario;
            }
            else {
                eps = 0.125 * baseCotización;
                pensión = 0.16 * baseCotización;
                if (arl == 1) arl = 0.00522 * baseCotización;
                else if (arl == 2) arl = 0.01044 * baseCotización;
                else if (arl == 3) arl = 0.02436 * baseCotización;
                else if (arl == 4) arl = 0.04350 * baseCotización;
                else arl=0.06960 * baseCotización;
                salarioReal = salario - eps - pensión-arl;
                salarioanual = salarioReal * 12;
            }
            double deducciones = eps + pensión + arl;
            Console.WriteLine("su ARL ES: " + arl + ", su pensión es: " + pensión+ ", su eps es: "+eps+" y sus deducciones mensuale son: "+ deducciones);
            Console.WriteLine("su salario real es: " + salarioReal + " y su salario anual es: " + salarioanual);
        }
    }
}
