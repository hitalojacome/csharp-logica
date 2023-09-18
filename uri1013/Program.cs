using System;

namespace uri1013 {
    class Program {
        static void Main(string[] args) {
            
            int A, B, C, greatestAB, greatest;

            string[] values = Console.ReadLine().Split(' ');
            A = int.Parse(values[0]);
            B = int.Parse(values[1]);
            C = int.Parse(values[2]);

            greatestAB = (A + B + Math.Abs(A - B)) / 2;
            greatest = (greatestAB + C + Math.Abs(greatestAB - C)) / 2;

            Console.WriteLine(greatest + " eh o maior!");

        }
    }
}