using System;

namespace vet4 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos números deseja inserir? ");
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            Console.Write("Insira os valores do vetor: ");
            string[] values = Console.ReadLine().Split(' ');

            for (int i=0; i<n; i++) {
                vet[i] = double.Parse(values[i]);
            }

            double sum = 0;
            for (int i=0; i<n; i++) {
                sum += vet[i];
            } 
            double avg = sum / n;
            Console.WriteLine("Média dos valores: " + avg);

            Console.Write("Valores a baixo da média: ");
            for (int i=0; i<n; i++) {
                if (vet[i] < avg) {
                    Console.Write(vet[i] + " ");
                }
            }         
             
        }
    }
}