using System;

namespace uri1017 {
    class Program {
        static void Main(string[] args) {

            int time, velocity;
            double distance, liters;

            time = int.Parse(Console.ReadLine());
            velocity = int.Parse(Console.ReadLine());

            distance = velocity * time;
            liters = distance / 12;

            Console.WriteLine(liters.ToString("F3"));
            
        }
    }
}