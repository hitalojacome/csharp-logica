using System;

namespace uri1047 {
    class Program {
        static void Main(string[] args) {

            string[] inputTimes = Console.ReadLine().Split(' ');
            int initialHour = int.Parse(inputTimes[0]);
            int initialMinute = int.Parse(inputTimes[1]);
            int finalHour = int.Parse(inputTimes[2]);
            int finalMinute = int.Parse(inputTimes[3]);

            int initialTimeInMinutes = initialHour * 60 + initialMinute;
            int finalTimeInMinutes = finalHour * 60 + finalMinute;

            int duration;
            if (initialTimeInMinutes < finalTimeInMinutes) {
                duration = finalTimeInMinutes - initialTimeInMinutes;
            }
            else {
                duration = (24 * 60 - initialTimeInMinutes) + finalTimeInMinutes;
            }

            int durationHours = duration / 60;
            int durationMinutes = duration % 60;

            Console.WriteLine("O JOGO DUROU " + durationHours + 
                    " HORA(S) E " + durationMinutes + " MINUTO(S)");
            
        }
    }
}