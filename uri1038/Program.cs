using System;

namespace uri1038 {
    class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');
            int codPedido = int.Parse(vet[0]);
            int quantity = int.Parse(vet[1]);

            double total = 0.0;
            if (codPedido == 1) {
                total = quantity * 4.0;
            } else if (codPedido == 2) {
                total = quantity * 4.5;
            } else if (codPedido == 3) {
                total = quantity * 5.0;
            } else if (codPedido == 4) {
                total = quantity * 2.0;
            } else if (codPedido == 5) {
                total = quantity * 1.5;
            } else {
                Console.WriteLine("Pedido não cadastrado.");
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2"));
            
        }
    }
}