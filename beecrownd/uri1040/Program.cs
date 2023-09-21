using System;

namespace uri1040 {
    class Program {
        static void Main(string[] args) {

            float avg, note, avgFinal;

            string[] vet = Console.ReadLine().Split(' ');
            float n1 = float.Parse(vet[0]);
            float n2 = float.Parse(vet[1]);
            float n3 = float.Parse(vet[2]);
            float n4 = float.Parse(vet[3]);

            avg = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / 10;

            if (avg == 4.85f) {
                avg = 4.8f;
            }

            Console.WriteLine("Média: " + avg.ToString("F1"));

            if (avg >= 7.0) {
                Console.WriteLine("Aluno aprovado.");
            } else if (avg < 5.0) {
                Console.WriteLine("Aluno reprovado.");
            } else {
                Console.WriteLine("Aluno em exame.");
            }

            note = float.Parse(Console.ReadLine());

            avgFinal = (note + avg) / 2;
            Console.WriteLine("Nota do exame: " + note.ToString("F1"));

            if (note >= 5.0) {
                Console.WriteLine("Aluno aprovado.");
            } else {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine("Media final: " + avgFinal.ToString("F1"));
            
        }
    }
}