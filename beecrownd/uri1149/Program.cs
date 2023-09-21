using System;

namespace uri1149 {
    class Program {
        static void Main(string[] args) {

            int A, N, i, sum;

            string[] values = Console.ReadLine().Split(' ');

            A = int.Parse(values[0]);

            i = 1;
            N = int.Parse(values[i]);
            while (N <= 0) {
                i += 1;
                N = int.Parse(values[i]);
            }

            sum = 0;
            for (i = 0; i < N; i++) {
                sum += A + i;
            }

            Console.WriteLine(sum);
            
        }
    }
}