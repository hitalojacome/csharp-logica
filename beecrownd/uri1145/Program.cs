using System;

namespace uri1145 {
    class Program {
        static void Main(string[] args) {

            int x, y;

            string[] values = Console.ReadLine().Split(' ');
            x = int.Parse(values[0]);
            y = int.Parse(values[1]);

            for (int i = 1; i <= y; i++) {
                Console.Write(i);
                if (i % x == 0) {
                    Console.WriteLine();
                } else {
                    Console.Write(' ');
                }
            }
            
        }
    }
}