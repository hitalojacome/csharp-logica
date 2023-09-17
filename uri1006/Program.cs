using System;

namespace uri1006 {
    class Program {
        static void Main(string[] args) {

            double a, b, c, media;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            media = ((a * 2.0) + (b * 3.0) + (c * 5.0)) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1"));

        }
    }
}