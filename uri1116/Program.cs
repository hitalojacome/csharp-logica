using System;

namespace uri1116 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            for (int i =0; i < n; i++) {

                string[] values = Console.ReadLine().Split(' ');
                int x = int.Parse(values[0]);
                int y = int.Parse(values[1]);

                if (y == 0) {
                    Console.WriteLine("divisao impossivel");
                } else {
                    double division = (double) x / y;
                    Console.WriteLine(division.ToString("F1"));
                }

            }
            
        }
    }
}