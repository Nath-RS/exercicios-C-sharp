using System;

namespace URI_1035
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            int A, B, C, D;

            input = Console.ReadLine().Split(' ');
            A = int.Parse(input[0]);
            B = int.Parse(input[1]);
            C = int.Parse(input[2]);
            D = int.Parse(input[3]);

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else Console.WriteLine("valores não aceitos");

        }
    }
}
