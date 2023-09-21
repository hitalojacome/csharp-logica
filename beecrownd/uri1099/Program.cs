using System;

namespace uri1099 {
    class Program {
        static void Main(string[] args) {
            
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {

                string[] values = Console.ReadLine().Split(' ');
                int x = int.Parse(values[0]);
                int y = int.Parse(values[1]);

                if (x > y) {
                    int aux = x;
                    x = y;
                    y = aux;
                }

                int sum = 0;
                for (int j = x + 1; j < y; j++) {
                    if (j % 2 != 0) {
                        sum = sum + j;
                    }
                }
                Console.WriteLine(sum);
            }

        }
    }
}