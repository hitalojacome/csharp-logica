using System;

namespace uri1008 {
    class Program {
        static void Main(string[] args) {
            
            int idEmployed, hour;
            double valueHour, salary;

            idEmployed = int.Parse(Console.ReadLine());
            hour = int.Parse(Console.ReadLine());
            valueHour = double.Parse(Console.ReadLine());

            salary = valueHour * hour;

            Console.WriteLine("Employed number = " + idEmployed);
            Console.WriteLine("Salary = U$" + salary.ToString("F2"));

        }
    }
}