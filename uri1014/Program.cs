using System;

namespace uri1014 {
    class Program {
        static void Main(string[] args) {
            
            int x;
            double y, consumption;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            consumption = x / y;

            Console.WriteLine(consumption.ToString("F3") + " KM/L");

        }
    }
}