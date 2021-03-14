using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoA;
            double ladoB;
            double ladoC;
            double resultP;
            double resultA;

            Console.Write("Digite o Valor de A: ");
            ladoA = double.Parse(Console.ReadLine());

            Console.Write("Digite o Valor de B: ");
            ladoB = double.Parse(Console.ReadLine());

            Console.Write("Digite o Valor de C: ");
            ladoC = double.Parse(Console.ReadLine());
            Console.Write("\n");

            resultP = (ladoA + ladoB + ladoC) / 2;
            resultA = Math.Sqrt(resultP * (resultP - ladoA) * (resultP - ladoB) *(resultP - ladoC));

            Console.WriteLine("Semiperímetro = {0}", resultP);
            Console.WriteLine("Area = {0}(cm²)", resultA);
            Console.Write("\n");

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
