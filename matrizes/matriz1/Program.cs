using System;

namespace matriz1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Insira a quantidade de linhas e colunas (L C): ");
            string[] vet = Console.ReadLine().Split(' ');
            int line = int.Parse(vet[0]);
            int column = int.Parse(vet[1]);

            int[,] mat = new int[line, column];

            for (int i=0; i<line; i++) {
                Console.Write($"Insira os valores da {i+1}° linha: ");
                string[] values = Console.ReadLine().Split(' ');
                for (int j=0; j<column; j++) {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            Console.Write("Valores negativos: ");
            for (int i=0; i<line; i++) {
                for (int j=0; j<column; j++) {
                    if (mat[i,j] <0) {
                        Console.Write(mat[i,j] + " ");
                    }
                }
            }
        }    
    }
}