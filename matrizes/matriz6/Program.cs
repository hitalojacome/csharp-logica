using System;

namespace matriz6 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Insira o tamanho da matriz quadrada: ");
            int n = int.Parse(Console.ReadLine());
            double[,] mat = new double[n,n];

            for (int i=0; i<n; i++) {
                Console.Write($"Insira os valores da {i+1}° Linha: ");
                string[] values = Console.ReadLine().Split(' ');
                for (int j=0; j<n; j++) {
                    mat[i,j] = double.Parse(values[j]); 
                }
            }

            double sum = 0;
            for (int i=0; i<n; i++) {
                for (int j=0; j<n; j++) {
                    if (mat[i,j] > 0) {
                        sum += mat[i,j];
                    }
                }
            }
            Console.WriteLine($"Soma dos valores positivos: {sum}");

            Console.Write("Qual linha deseja visualizar? ");
            int chosenLine = int.Parse(Console.ReadLine());
            for (int i=0; i<n; i++) {
                for (int j=0; j<n; j++) {
                    Console.Write
                }
            }
            
        }
    }
}