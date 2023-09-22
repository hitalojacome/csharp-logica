using System;

namespace matriz5 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Insira a quantidade de linhas e colunas: ");
            string[] size = Console.ReadLine().Split(' ');
            int line = int.Parse(size[0]);
            int column = int.Parse(size[1]);

            int[,] matA = new int[line, column];
            for (int i=0; i<line; i++) {
                Console.Write($"Insira os valores da {i+1}° linha da primeira matriz: ");
                string[] values = Console.ReadLine().Split(' ');
                for (int j=0; j<column; j++) {
                    matA[i,j] = int.Parse(values[j]);
                }
            }

            int[,] matB = new int[line, column];
            for (int i=0; i<line; i++) {
                Console.Write($"Insira os valores da {i+1}° linha da segunda matriz: ");
                string[] values = Console.ReadLine().Split(' ');
                for (int j=0; j<column; j++) {
                    matB[i,j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Soma dos elementos:");
            int[,] matC = new int[line, column];
            for (int i=0; i<line; i++) {
                for (int j=0; j<column; j++) {
                    matC[i,j] = matA[i,j] + matB[i,j];
                    Console.Write(matC[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}