using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su salario mensual");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su tipo de contrato: dependiente o independiente");
            string tipodecontrato = Console.ReadLine();
            Console.WriteLine("ingrese su nivel de riesgo");
            double riesgo = double.Parse(Console.ReadLine());

            double smmlv = 877803;
            double baseCotización = 0.4 * salario;
            if (baseCotización < smmlv) baseCotización = smmlv;
            //switch para el tipo de contrato 
            switch (tipodecontrato)
            {
                case "dependiente":
                    double pensión = baseCotización * 0.04;
                    double eps = baseCotización * 0.04;
                    double salariomensual = (salario - pensión - eps);
                    double salarioanual = (salariomensual * 12) + salario;
                    Console.WriteLine("su salario mensual es:" + salariomensual + "y su salario anual es:" + salarioanual);
                    break;

                case "independiente":
                    Console.WriteLine("Cuál es su nivel de riesgo");
                    double ipensión = baseCotización * 0.16;
                    double ieps =baseCotización * 0.125;

                    //switch tipo de riesgo

                    switch (riesgo)
                    {
                        case 1:
                            double arl = baseCotización * 0.00522;
                            break;

                        case 2:
                            double arl2 = baseCotización * 0.01044;
                            break;

                        case 3:
                            double arl3 = baseCotización * 0.02436;
                            break;

                        case 4:
                            double arl4 = baseCotización * 0.0435;
                            break;

                        case 5:
                            double arl5 = baseCotización * 0.0696;
                            break;



                    }

                    double salariomensuali = (salario - ipensión - ieps - riesgo);
                    double salarioanuali = salariomensuali * 12;
                    Console.WriteLine("su salario mensual es:" + salariomensuali + "y su salario anual es:" + salarioanuali);

                    break;

            }
        }
    }
}
