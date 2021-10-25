using System;

namespace URI_1155
{
    class Program
    {
        static void Main(string[] args)
        {
            int leitura;
            double s,j;
            j = 1.0;
            s = 0;

            for(double i = 1.00; i <= 100; i++)
            {
                s += (1 / i);
            }

            Console.WriteLine(s);
        }
    }
}
