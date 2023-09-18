using System;

namespace uri1015 {
    class Program {
        static void Main(string[] args) {

            string[] axes;
            double x1, y1, x2, y2, distance;

            axes = Console.ReadLine().Split(' ');
            x1 = double.Parse(axes[0]);
            y1 = double.Parse(axes[1]);

            axes = Console.ReadLine().Split(' ');
            x2 = double.Parse(axes[0]);
            y2 = double.Parse(axes[1]);

            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Distância: " + distance.ToString("F4"));
            
        }
    }
}