using System;

namespace uri1020 {
    class Program {
        static void Main(string[] args) {

            int n, years, months, days, remainder;

            n = int.Parse(Console.ReadLine());

            years = n / 365;
            remainder = n % 365;
            months = remainder / 30;
            days = remainder % 30;

            Console.WriteLine(years + " ano(s)");
            Console.WriteLine(months + " mês(es)");
            Console.WriteLine(days + " dia(s)");
            
        }
    }
}