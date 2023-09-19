using System;

namespace uri1044 {
    class Program {
        static void Main(string[] args) {

            string[] values = Console.ReadLine().Split(' ');
            int A = int.Parse(values[0]);
            int B = int.Parse(values[1]);

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Os números digitidos SÃO múltiplos");
            } else {
                Console.WriteLine("Os números digitidos NÃO são múltiplos");
            }
            
        }
    }
}