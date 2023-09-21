using System;

namespace uri1010 {
    class Program {
        static void Main(string[] args) {
            
            string[] part1 = Console.ReadLine().Split(' ');
            int code1 = int.Parse(part1[0]);
            int quant1 = int.Parse(part1[1]);
            double value1 = double.Parse(part1[2]);

            string[] part2 = Console.ReadLine().Split(' ');
            int code2 = int.Parse(part2[0]);
            int quant2 = int.Parse(part2[1]);
            double value2 = double.Parse(part2[2]);

            double total = (quant1 * value1) + (quant2 * value2);

            Console.WriteLine("Valor a pagar = R$" + total.ToString("F2"));

        }
    }
}