using System;

namespace uri1021 {
    class Program {
        static void Main(string[] args) {

            double n;
            int quotient, remainder, note, coin;

            n = double.Parse(Console.ReadLine());

            remainder = (int) (n * 100.00 + 0.5); // casting

            Console.WriteLine("NOTAS: ");

            note = 100;
            quotient = remainder / (note * 100);
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            remainder %= (note * 100);

            note = 50;
            quotient = remainder / (note * 100);
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            remainder %= (note * 100);

            note = 20;
            quotient = remainder / (note * 100);
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            remainder %= (note * 100);

            note = 10;
            quotient = remainder / (note * 100);
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            remainder %= (note * 100);

            note = 5;
            quotient = remainder / (note * 100);
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            remainder %= (note * 100);

            note = 2;
            quotient = remainder / (note * 100);
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            remainder %= (note * 100);

            Console.WriteLine("MOEDAS: ");

            coin = 100;
            quotient = remainder / coin;
            Console.WriteLine(quotient + " moeda(s) de R$ 1,00");
            remainder %= coin;

            coin = 50;
            quotient = remainder / coin;
            Console.WriteLine(quotient + " moeda(s) de R$ 0,50");
            remainder %= coin;

            coin = 25;
            quotient = remainder / coin;
            Console.WriteLine(quotient + " moeda(s) de R$ 0,25");
            remainder %= coin;

            coin = 10;
            quotient = remainder / coin;
            Console.WriteLine(quotient + " moeda(s) de R$ 0,10");
            remainder %= coin;

            coin = 5;
            quotient = remainder / coin;
            Console.WriteLine(quotient + " moeda(s) de R$ 0,05");
            remainder %= coin;

            Console.WriteLine(remainder + " moeda(s) de R$ 0.01");
            
        }
    }
}