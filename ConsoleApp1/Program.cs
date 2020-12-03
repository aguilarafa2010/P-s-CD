using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 5) Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            // código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

            Console.WriteLine("Informe o código da peça 1:");
            var cod1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de peças 1 compradas:");
            var qte1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço unitário da peça 1:");
            var prc1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o código da peça 2:");
            var cod2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de peças 2 compradas:");
            var qte2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço unitário da peça 2:");
            var prc2 = Convert.ToDouble(Console.ReadLine());

            var total = prc1 * qte1 + prc2 * qte2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total}");

        }
    }
}
