using System;

namespace URi_1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, leitura;

            leitura = int.Parse(Console.ReadLine());

            for(int i = 1; i <= leitura; i++)
            {
                if(i % 2 == 0)
                {
                    n = (int)Math.Pow(i, 2);
                    Console.WriteLine(i + "^2 = " + n);
                }


            }
        }
    }
}
