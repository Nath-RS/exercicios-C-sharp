using System;

namespace URI_1156
{
    class Program
    {
        static void Main(string[] args)
        {
            int leitura;
            double s, j;
            j = 1.0;
            s = 0;

            for (double i = 1.00; i <= 39; i+=2)
            {
                s += (i / j);
                j = (j+j);
            }

            Console.WriteLine(s);
        }
    }
}
