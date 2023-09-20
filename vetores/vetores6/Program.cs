using System;

namespace vet6 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Os dados de quantas pessoas serão inseridas? ");
            int n = int.Parse(Console.ReadLine());
            string[] name = new string[n];
            int[] age = new int[n];

            Console.WriteLine("Insira os o nome e a idade das pessoas: ");
            for (int i=0; i<n; i++) {
                string[] people = Console.ReadLine().Split(' ');
                name[i] = people[0];
                age[i] = int.Parse(people[1]);
            }
            
            int older = 0;
            int olderPosition = 0;
            for (int i=0; i<n; i++) {
                if (older < age[i]) {
                    older = age[i];
                    olderPosition = i;
                }
            }

            string olderName = name[olderPosition];
            Console.WriteLine("A pessoa mais velha da lista é: " + olderName); 
             
        }
    }
}