using System;

namespace uri1046 {
    class Program {
        static void Main(string[] args) {

            string[] hours = Console.ReadLine().Split(' ');
            int initialHour = int.Parse(hours[0]);
            int finalHour = int.Parse(hours[1]);

            int duration;
            if (initialHour < finalHour) {
                duration = finalHour - initialHour;
            } else {
                duration = 24 - initialHour + finalHour;
            }

            Console.WriteLine("O JOGO DUROU " + duration + " HORA(S)");
            
        }
    }
}