using System;

namespace vet8 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Os dados de quantas pessoas serão inseridos? ");
            int n = int.Parse(Console.ReadLine());
            double[] heights = new double[n];
            char[] sex = new char[n];

            Console.WriteLine("Insira a altura e o sexo:");
            for (int i=0; i<n; i++) {
                string[] data = Console.ReadLine().Split(' ');
                heights[i] = double.Parse(data[0]);
                sex[i] = char.ToUpper(data[1][0]);
            }

            double sum = 0; int cont = 0; double heigher = 0; double lower = 10000;
            int men = 0;
            for (int i=0; i<n; i++) {
                if (heights[i] > heigher) {
                    heigher = heights[i];
                }

                if (heights[i] < lower) {
                    lower = heights[i];
                }

                if (sex[i] != 'M') {
                    sum += heights[i];
                    cont++;
                }

                if (sex[i] == 'M') {
                    men++;
                }
            }
            double avarageWomenHeight = sum / cont;

            Console.WriteLine("Menor altura = " + lower.ToString("F2"));
            Console.WriteLine("Maior altura = " + heigher.ToString("F2"));
            Console.WriteLine("Média das altura das mulheres = " + avarageWomenHeight.ToString("F2"));
            Console.WriteLine("Numero de homens = " + men);
            
        }
    }
}