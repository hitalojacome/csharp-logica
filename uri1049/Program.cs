using System;

namespace uri1049 {
    class Program {
        static void Main(string[] args) {

            string option1 = Console.ReadLine();
            string option2 = Console.ReadLine();
            string option3 = Console.ReadLine();

            if (option1 == "vertebrado" && option2 == "mamifero" && option3 == "onivoro") {
                Console.WriteLine("homem");
            } else if (option1 == "vertebrado" && option2 == "mamifero" && option3 == "herbivoro") {
                Console.WriteLine("vaca");
            } else if (option1 == "vertebrado" && option2 == "ave" && option3 == "onivoro") {
                Console.WriteLine("pomba"); 
            } else if (option1 == "vertebrado" && option2 == "ave" && option3 == "carnivoro") {
                Console.WriteLine("aguia");
            } else if (option1 == "invertebrado" && option2 == "inseto" && option3 == "hematofago") {
                Console.WriteLine("pulga");
            } else if (option1 == "invertebrado" && option2 == "inseto" && option3 == "herbivoro") {
                Console.WriteLine("lagarta");
            } else if (option1 == "invertebrado" && option2 == "anelideo" && option3 == "hematofago") {
                Console.WriteLine("sanguessuga");
            } else if (option1 == "invertebrado" && option2 == "anelideo" && option3 == "onivoro") {
                Console.WriteLine("minhoca");
            } else {
                Console.WriteLine("Valores incorretos!");
            }
            
        }
    }
}