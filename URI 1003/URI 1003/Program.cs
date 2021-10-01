using System;

namespace URI_1003
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

            Console.WriteLine("A soma de " + A + " e " + B + " é igual a " + (A + B));
        }
    }
}
