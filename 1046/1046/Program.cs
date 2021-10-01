using System;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            if(A > B)
            {
                int diferenca = 24 - A; 
                diferenca += B;
                Console.WriteLine("O JOGO DUROU " + diferenca + " HORA(S)");
            }
            else if(A == B && B == A)
            {
                Console.WriteLine("O JOGO DUROU " + 24 + " HORA(S)");
            }
            else
            {
                int diferenca = B - A;
                Console.WriteLine("O JOGO DUROU " + diferenca + " HORA(S)");
            }
        }
    }
}
