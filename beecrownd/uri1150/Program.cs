using System;

namespace uri1150 {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            while (z <= x) {
                z = int.Parse(Console.ReadLine());
            }

            int count = 1;
            int sum = x;
            do {
                x += 1;
                sum += x;
                count += 1;
            } while (sum <= z);

            Console.WriteLine(count);
            
        }
    }
}