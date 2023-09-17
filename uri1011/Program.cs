using System;

namespace uri1011{
    class Program {
        static void Main(string[] args) {

            double pi, radius, volume;

            pi = 3.14159;
            radius = double.Parse(Console.ReadLine());

            volume = 4.0 / 3.0 * pi * Math.Pow(radius, 3.0);

            Console.WriteLine("VOLUME = " + volume.ToString("F3"));
            
        }
    }
}