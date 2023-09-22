using System;

namespace matriz7 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Insira a quantidade de filas: ");
            int line = int.Parse(Console.ReadLine());

            Console.Write("Insira a quantidade de soldados: ");
            int soldier = int.Parse(Console.ReadLine());

            int[,] army = new int[line, soldier];
            for (int i=0; i<line; i++) {
                Console.Write($"Insira o número dos soldados da {i+1}° Linha: ");
                string[] soldierNumber = Console.ReadLine().Split(' ');
                for (int j=0; j<soldier; j++) {
                    army[i,j] = int.Parse(soldierNumber[j]);
                }
            }

            Console.Write("Qual fila ocorrerá o 'girar fila'? ");
            int chosenRow = int.Parse(Console.ReadLine()) - 1;
            int lastOne = army[chosenRow, soldier - 1];
            for (int j=soldier-1; j>0; j--) {
                army[chosenRow, j] = army[chosenRow, j -1];
            }

            army[chosenRow, 0] = lastOne;
            Console.WriteLine("Batalhão após o 'gira fila': ");
            for (int i=0; i<line; i++) {
                for (int j=0; j<soldier; j++) {
                    Console.Write(army[i,j] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}