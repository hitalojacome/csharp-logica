using System;

namespace uri1071 {
    class Program {
        static void Main(string[] args) {

            int x, y, min, max, sum;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y) {
                min = x;
                max = y;
            } else {
                min = y;
                max = x;
            }

            sum = 0;
            for (int i = min + 1; i < max; i++) {
                if (i % 2 != 0) {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
            
        }
    }
}