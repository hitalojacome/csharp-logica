using System;

namespace vet3 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos números deseja inserir? ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int[] B = new int[n];

            Console.Write("Insira os valores do primeiro vetor: ");
            string[] valueA = Console.ReadLine().Split(' ');

            Console.Write("Insira os valores do segundo vetor: ");
            string[] valueB = Console.ReadLine().Split(' ');

            for (int i=0; i<n; i++) {
                A[i] = int.Parse(valueA[i]);
                B[i] = int.Parse(valueB[i]);
            }

            int[] C = new int[n];
            Console.Write("Segue a soma dos valores: ");
            for (int i=0; i<n; i++) {
                C[i] = A[i] + B[i];
                Console.Write(C[i] + " ");
            }
            
        }
    }
}