using System;

namespace vet1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos números deseja inserir? ");
            int n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            Console.Write("Por favor, insira os valores: ");
            string[] values = Console.ReadLine().Split(' ');

            for (int i=0; i<n; i++) {
                vet[i] = double.Parse(values[i]);
            }

            double higher = vet[0];
            int highPosition = 0;

            for (int i=0; i<n; i++) {
                if (higher < vet[i]) { 
                    higher = vet[i];
                    highPosition = i;
                }
            }

            Console.Write("Maior valor inserido: " + higher.ToString("F1") + " | ");
            Console.WriteLine("Posição do vetor: " + highPosition);
            
        }
    }
}