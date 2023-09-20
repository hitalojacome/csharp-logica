using System;

namespace vet9 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantas mercadorias deseja informar? ");
            int n = int.Parse(Console.ReadLine());
            string[] products = new string[n];
            double[] buyPrice = new double[n];
            double[] sellPrice = new double[n];

            Console.WriteLine("Insira o nome, preço de compra e preço de venda dos produtos: ");
            for (int i=0; i<n; i++) {
                string[] data = Console.ReadLine().Split(' ');
                products[i] = data[0];
                buyPrice[i] = double.Parse(data[1]);
                sellPrice[i] = double.Parse(data[2]);
            }

            int countBelow10 = 0; int countBetween10and20 = 0; int countAbove20 = 0;
            for (int i=0; i<n; i++) {

                double profit = sellPrice[i] - buyPrice[i];
                double profitPercentage = profit / buyPrice[i] * 100.00;

                if (profitPercentage < 10.00) {
                    countBelow10++;
                } else if (profitPercentage <= 20.00) {
                    countBetween10and20++;
                } else {
                    countAbove20++;
                }
            }
            
            double totalBuy = 0; double totalSell = 0; double totalProfit = 0;
            for (int i=0; i<n; i++) {
                totalBuy += buyPrice[i];
                totalSell += sellPrice[i];
            }

            totalProfit = totalSell - totalBuy;

            Console.WriteLine("Lucro abaixo 10%: " + countBelow10);
            Console.WriteLine("Lucro entre 10% e 20%: " + countBetween10and20);
            Console.WriteLine("Lucro acima de 20%: " + countAbove20);
            Console.WriteLine("Valor total de compra: R$ " + totalBuy.ToString("F2"));
            Console.WriteLine("Valor total de venda: R$ " + totalSell.ToString("F2"));
            Console.WriteLine("Lucro total: R$ " + totalProfit.ToString("F2"));
             
        }
    }
}