using System;

namespace URI_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B;
            double resultado;

            Console.WriteLine("Digite um valor para a nota 1:");
            A = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para a nota 2:");
            B = float.Parse(Console.ReadLine());
            resultado = (A * 0.35) + (B * 0.65);
            Console.WriteLine("A média é " + Math.Abs(resultado));

        }
    }
}
