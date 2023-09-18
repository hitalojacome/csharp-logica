using System;

namespace uri1101 {
    class Program {
        static void Main(string[] args) {

            string[] values = Console.ReadLine().Split(' ');
            int m = int.Parse(values[0]);
            int n = int.Parse(values[1]);

            while (m > 0 && n > 0) {

                int smaller = m;
                int greater = n;

                if (m > n) {
                    smaller = n;
                    greater = m;
                }

                int sum = 0;
                for (int i = smaller; i <= greater; i++) {
                    sum += i;
                    Console.Write(i + " ");
                }
                Console.WriteLine("Sum=" + sum);

                values = Console.ReadLine().Split(' ');
                m = int.Parse(values[0]);
                n = int.Parse(values[1]);
            }
        }
    }
}