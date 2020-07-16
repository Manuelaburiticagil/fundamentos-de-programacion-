using System;

namespace Desafío_01_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese si peso en kilos");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su altura en metros");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / Math.Pow(altura, 2);

            if(imc < 16){
                Console.WriteLine("Su índice de masa corporal es " + imc + " Y usted tiene desnutrición severa");
            }
            else if (16 <= imc && imc < 18.5){
                Console.WriteLine("Su índice de masa corporal es " + imc + " Y usted tiene desnutrición moderada");
            }
            else if (18.5 <= imc && imc < 22) {
                Console.WriteLine("Su índice de masa corporal es " + imc + " Y usted tiene bajo peso");
            }
            else if (22 <= imc && imc < 25){
                Console.WriteLine("Su índice de masa corporal es " + imc + " Y esta normal");
            }
            else if (25 <= imc && imc < 30) { 
                Console.WriteLine("Su índice de masa corporal es " + imc + " Y usted tiene sobrepeso");
            }
            else if (30 <= imc && imc < 35)  {
                Console.WriteLine("Su índice de masa corporal es " + imc + " Y usted tiene obesidad tipo I");
            }
            else if (35 <= imc && imc < 40){
                Console.WriteLine("Su índice de masa corporal es " + imc + " Y usted tiene obesidad tipo II");
            }
            else {
                Console.WriteLine("Su índice de masa corporal es " + imc + " Y usted tiene obesidad tipo III");
            }
        }
    }
}
