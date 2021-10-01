using System;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            float n = 3.14159f,r;
            
            Console.WriteLine("Calculo da circunferência !  A = n * (r*r)");
            Console.WriteLine("Digite o Valor do Raio (r)");
            r = float.Parse(Console.ReadLine());

            double a = n * (r*r);

            Console.WriteLine("o Resultado e A = " + a);
        }
    }
}
