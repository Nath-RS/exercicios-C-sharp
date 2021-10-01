using System;

namespace URI_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            if (B % A == 0 && A % B == A || A % B == 0 && B % A == B)
            {
                Console.WriteLine("Sao multiplos");
            }
            else Console.WriteLine("Nao sao multiplos");

        }
    }
}
