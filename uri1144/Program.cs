using System;

namespace uri1144 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                int second = i * i;
                int third = i * i * i;
                Console.WriteLine(i + " " + second + " " + third);
                Console.WriteLine(i + " " + (second + 1) + " " + (third + 1));

            }
            
        }
    }
}