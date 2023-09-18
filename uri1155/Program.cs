using System;

namespace uri1155 {
    class Program {
        static void Main(string[] args) {

            double sum = 0;
            for (int i = 1; i <= 100; i++) {
                sum += 1.0 / i;
            }

            Console.WriteLine(sum.ToString("F2"));
            
        }
    }
}