using System;

namespace uri1080 {
    class Program {
        static void Main(string[] args) {

            int x = 0; int highValue = 0; int highValuePosition = 0;
            for (int i=0; i<10; i++) {
                x = int.Parse(Console.ReadLine());

                if (x > highValue) {
                    highValue = x;
                    highValuePosition = i;
                }
            }

            Console.WriteLine($"Maior valor dos 10 inseridos foi {highValue}");
            Console.WriteLine($"Posição dentre os 10: {highValuePosition+1}°");
            
        }
    }
}