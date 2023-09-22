using System;

namespace matriz4 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Insira a quantidade de linhas e colunas: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n,n];

            for (int i=0; i<n; i++) {
                Console.Write($"Insira os valores da {i+1}° Linha: ");
                string[] values = Console.ReadLine().Split(' ');
                for (int j=0; j<n; j++) {
                    mat[i,j] = int.Parse(values[j]); 
                }
            }

            int sum = 0;
            for (int i=0; i<n; i++) {
                for (int j = i+1; j<n; j++) {
                    sum += mat[i,j];
                }
            }

            Console.WriteLine($"A soma dos valores ACIMA da diagonal principal é: {sum}");
            
        }
    }
}