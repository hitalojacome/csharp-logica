using System; 

namespace uri1009 {
        class Program {
            static void Main(string[] args) {
                
                string name;
                double fixSalary, totalSell, totalSalary;

                name = Console.ReadLine();
                fixSalary = double.Parse(Console.ReadLine());
                totalSell = double.Parse(Console.ReadLine());

                totalSalary = totalSell * 15.0 / 100 + fixSalary;

                Console.WriteLine("TOTAL = R$" + totalSalary.ToString("F2"));

            }
        }        
    }
