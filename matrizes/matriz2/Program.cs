using System;

namespace matriz2 {
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

            for (int i=0; i<n; i++) {
                int sum = 0;
                for (int j=0; j<n; j++) {
                    sum += mat[i, j];
                }
                Console.WriteLine($"Soma dos valores da {i+1}° linha: {sum}");
            }                     
            
        }
    }
}