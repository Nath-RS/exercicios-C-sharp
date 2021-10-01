using System;

namespace URI_1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            Console.WriteLine("Digite um valor Inteiro:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro Valor inteiro:");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("O produto de " + A + " e " + B + " é igual a " + (A * B));
        }
    }
}
