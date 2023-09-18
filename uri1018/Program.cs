using System;

namespace uri1018 {
    class Program {
        static void Main(string[] args) {

            int n, quotient, remainder, note;

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            remainder = n;

            note = 100;
            quotient = remainder / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            remainder %= note;

            note = 50;
            quotient = remainder / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            remainder %= note;

            note = 20;
            quotient = remainder / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            remainder %= note;

            note = 10;
            quotient = remainder / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            remainder %= note;

            note = 5;
            quotient = remainder / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            remainder %= note;

            note = 2;
            quotient = remainder / note;
            Console.WriteLine(quotient + " nota(s) de R$ " + note + ",00");
            remainder %= note;

            Console.WriteLine(remainder + " nota(s) de R$ 1,00");

        }
    }
}