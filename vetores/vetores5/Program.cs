using System;

namespace vet5 {
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
            int cont = 0;
            for (int i=0; i<n; i++) {
                if (vet[i] % 2 == 0) {
                    sum += vet[i];
                    cont++;
                }
            } 

            double avg = sum / cont;   
            Console.WriteLine("Média dos valores pares: " + avg);
            
        }
    }
}