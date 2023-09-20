using System;

namespace vet2 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos números deseja inserir? ");
            int n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];

            Console.Write("Por favor, insira os valores: ");
            string[] values = Console.ReadLine().Split(' ');

            for (int i=0; i<n; i++) {
                vet[i] = int.Parse(values[i]);
            }

            Console.Write("Dos números que inseriu, estes são os pares:");

            int cont = 0;
            for (int i=0; i<n; i++) {
                if (vet[i] % 2 == 0) {
                    Console.Write(" " + vet[i] + " ");
                    cont++;
                }
            }      
            Console.WriteLine();
            Console.Write("Quantidade de pares inseridos: " + cont);
            
        }
    }
}