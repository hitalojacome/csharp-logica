using System;

namespace vet7 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Os dados de quantos alunos serão inseridos? ");
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];
            double[] grade1 = new double[n];
            double[] grade2 = new double[n];

            Console.WriteLine("Insira o nome e as notas dos alunos: ");
            for (int i=0; i<n; i++) {
                string[] studentData = Console.ReadLine().Split(' ');
                names[i] = student[0];
                grade1[i] = double.Parse(studentData[1]);
                grade2[i] = double.Parse(studentData[2]);
            }

            Console.Write("Alunos aprovados: ");
            for (int i=0; i<n; i++) {
                double avg = (grade1[i] + grade2[i]) / 2;
                if (avg >= 6.0) {
                    Console.Write(name[i] + " ");
                }
            }
 
        }
    }
}