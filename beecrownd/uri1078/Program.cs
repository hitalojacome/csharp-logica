using System;

namespace uri1078 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                int result = i * N;
                Console.WriteLine(i + " x " +  N + " = " + result);
            }
            
        }
    }
}