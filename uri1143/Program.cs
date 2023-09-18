using System;

namespace uri1143 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                int first = i;
                int second = i * i;
                int third = i * i * i;
                Console.WriteLine($"{first} {second} {third}");
            }
            
        }
    }
}