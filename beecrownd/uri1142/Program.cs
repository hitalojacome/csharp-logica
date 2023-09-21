using System;

namespace uri1142 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int start = 1;
            for (int i = 1; i <= n; i++) {

                int second = start + 1;
                int third = start + 2;
                Console.WriteLine(start + " " + second + " " + third + " PUM");

                start += 4;
            }
            
        }
    }
}