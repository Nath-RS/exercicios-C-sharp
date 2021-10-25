using System;

namespace URi_1145
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y,i,j;

            string[] leitura = Console.ReadLine().Split(' ');

            x = int.Parse(leitura[0]);
            y = int.Parse(leitura[1]);
            j = 0;
            for(i = 1; i <= y; i++)
            {
                j++;
                Console.Write(i + " ");
                if(j == x)
                {
                    Console.Write("\n");
                    j = 0;
                }
            }
        }
    }
}
