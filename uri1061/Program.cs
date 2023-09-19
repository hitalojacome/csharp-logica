using System;

namespace uri1061 {
    class Program {
        static void Main(string[] args) {

            int day1, hour1, minute1, second1, 
            day2, hour2, minute2, second2, 
            day, hour, minute, second, start, end, duration, rest;

            // Ler a primeira linha, armazenando o valor de W (dia)
            string[] values = Console.ReadLine().Split(' ');
            day1 = int.Parse(values[1]);

            // Ler a segunda linha, armazenando o valor de X (hora), Y (minuto), Z (segundo)
            values = Console.ReadLine().Split(' ');
            hour1 = int.Parse(values[0]);
            minute1 = int.Parse(values[2]);
            second1 = int.Parse(values[4]);

            // Ler a terceira linha, armazenando o valor de W (dia)
            values = Console.ReadLine().Split(' ');
            day2 = int.Parse(values[1]);

            // Ler a segunda linha, armazenando o valor de X (hora), Y (minuto), Z (segundo)
            values = Console.ReadLine().Split(' ');
            hour2 = int.Parse(values[0]);
            minute2 = int.Parse(values[2]);
            second2 = int.Parse(values[4]);

            // Calculando o valor do inicio e fim, convertendo tudo para segundos
            start = (day1 - 1) * 24 * 60 * 60 + hour1 * 60 * 60 + minute1 * 60 + second1;
            end = (day2 - 1) * 24 * 60 * 60 + hour2 * 60 * 60 + minute2 * 60 + second2;

            // Calculando a duracao em segundos
            duration = end - start;

            // Agora vamos desmembrar a duracao em segundos para dia (W), hora (X), minutos (Y) e segundos (Z) restantes
            day = duration / (24 * 60 * 60);
            rest = duration % (24 * 60 * 60);
            hour = rest / (60 * 60);
            rest = rest % (60 * 60);
            minute = rest / 60;
            second = rest % 60;

            Console.WriteLine(day + " dia(s)");
            Console.WriteLine(hour + " hora(s)");
            Console.WriteLine(minute + " minuto(s)");
            Console.WriteLine(second + " segundo(s)");
            
        }
    }
}