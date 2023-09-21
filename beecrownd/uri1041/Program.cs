using System;

namespace uri1041 {
    class Program {
        static void Main(string[] args) {

            double x, y;

            string[] coordinates = Console.ReadLine().Split(' ');
            x = double.Parse(coordinates[0]);
            y = double.Parse(coordinates[1]);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            } else if (x == 0.0) {
                Console.WriteLine("Eixo Y");
            } else if (y == 0.0) {
                Console.WriteLine("Eixo Y"); 
            } else if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            } else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            } else if (x > 0 && y < 0) {
                Console.WriteLine("Q4");
            } else {
                Console.WriteLine("Q3");
            }
            
        }
    }
}