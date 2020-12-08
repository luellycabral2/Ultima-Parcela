using System;

namespace Ultima_Parcela
{
    class Program
    {
        static void Main(string[] args)
        {
            double ValorTotal;
            double Parcelas;
            double Result;

            DateTime DataAtual = DateTime.Now;
            DateTime ParcelaFinal;

            Console.Write("Digite o seu valor total:  ");
            ValorTotal = double.Parse(Console.ReadLine());

            Console.Write("Digite seu numero de Parcelas:  ");
            Parcelas = double.Parse(Console.ReadLine());
            Console.Write("\n");

            Result = ValorTotal / Parcelas;

            ParcelaFinal = DataAtual.AddMonths(8);
            Console.WriteLine($"Sua ultima Parcela sera em : {ParcelaFinal}, valor de R${Result}");


        }
    }
}
