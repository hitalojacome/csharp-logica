using System;

namespace uri1019 {
    class Program {
        static void Main(string[] args) {

            int n, remainder, hours, minutes, seconds;

            n = int.Parse(Console.ReadLine());

            hours = n / 3600;
            remainder = n % 3600;
            minutes = remainder / 60;
            seconds = remainder % 60;

            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
            
        }
    }
}