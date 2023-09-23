using System;

namespace uri1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int coelho = 0; int sapo = 0; int rato = 0; int quantidadeCobaia = 0;
            for (int i = 0; i < n; i++)
            {

                string[] vet = Console.ReadLine().Split(' ');
                quantidadeCobaia = int.Parse(vet[0]);
                char cobaia = char.Parse(vet[1]);

                if (cobaia == 'C')
                {
                    coelho += quantidadeCobaia;
                }
                else if (cobaia == 'R')
                {
                    rato += quantidadeCobaia;
                }
                else if (cobaia == 'S')
                {
                    sapo += quantidadeCobaia;
                }

            }

            int quantidade = coelho + rato + sapo;

            Console.WriteLine("Total: " + quantidade + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);

            double coelhoPercentual = (double)coelho / quantidade * 100.00;
            double ratoPercentual = (double)rato / quantidade * 100.00;
            double sapoPercentual = (double)sapo / quantidade * 100.00;

            Console.WriteLine("Percentual de coelhos: " + coelhoPercentual.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + ratoPercentual.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + sapoPercentual.ToString("F2") + " %");
        }
    }
}