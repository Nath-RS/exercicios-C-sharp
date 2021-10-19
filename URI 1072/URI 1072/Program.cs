using System;

namespace URI_1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, dentro, fora;

            dentro = 0;
            fora = 0;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());

                if(x <=20 && x >=10)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " in\n" + fora + " out");
        }
    }
}
