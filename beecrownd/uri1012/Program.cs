using System;

namespace uri1012 {
    class Program {
        static void Main(string[] args) {
            
            string[] values;
            double A, B, C, triangle, circle, trapezoid, square, rectangle;

            values = Console.ReadLine().Split(' ');
            A = double.Parse(values[0]);
            B = double.Parse(values[1]);
            C = double.Parse(values[2]);

            triangle = A * C / 2.0;
            circle = 3.14159 * C * C;
            trapezoid = (A + B) / 2.0 * C;
            square = B * B;
            rectangle = A * B;

            Console.WriteLine("TRIANGULO: " + triangle.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circle.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezoid.ToString("F3"));
            Console.WriteLine("QUADRADO: " + square.ToString("F3"));
            Console.WriteLine("RETANGULO: " + rectangle.ToString("F3"));

        }
    }
}