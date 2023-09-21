using System;

namespace uri1151 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i += 1) {
                if (i == n - 1) {
                    Console.WriteLine(a);
                } else {
                    Console.Write(a + " ");
                }

                int temp = b;
                b = a;
                a = temp + b;
            }
            
        }
    }
} 