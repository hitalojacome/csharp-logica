using System;

namespace uri1036 {
    class Program {
        static void Main(string[] args) {

            double a, b, c, delta, r1, r2;

            string[] values = Console.ReadLine().Split(' ');
            a = double.Parse(values[0]);
            b = double.Parse(values[1]);
            c = double.Parse(values[2]);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0.0 || delta < 0.0) {
                Console.WriteLine("Impossível calcular!");
            } else {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("R1 = " + r1.ToString("F5"));
                Console.WriteLine("R2 = " + r2.ToString("F5"));
            }
            
        }
    }
}