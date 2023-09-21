using System;

namespace uri1132 {
    class Program {
        static void Main(string[] args) {

            int x, y, smaller, greater, sum;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            greater = y;
            smaller = x;

            if (x > y) {
                greater = x;
                smaller = y;
            }

            sum = 0;
            for (int i = smaller; i <= greater; i++) {
                if (i % 13 != 0) {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
            
        }
    }
}