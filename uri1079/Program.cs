using System;

namespace uri1079 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine()); // número de casos

            for (int i = 0; i < n; i++) {

                string[] values = Console.ReadLine().Split(' ');
                double value1 = double.Parse(values[0]);
                double value2 = double.Parse(values[1]);
                double value3 = double.Parse(values[2]);

                double averageWeighted = (value1 * 2 + value2 * 3 + value3 * 5) / (2 + 3 + 5);

                Console.WriteLine(averageWeighted.ToString("F1"));
            }
            
        }
    }
}