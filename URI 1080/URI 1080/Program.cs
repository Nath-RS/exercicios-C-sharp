using System;

namespace URI_1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min, leitura,change;
            
            max = 0;
            min = 0;

            leitura = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {

                if (leitura > max)
                {
                    max = leitura;
                }
                else if (leitura < min)
                {
                    min = leitura;
                }

                leitura = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(max);
            Console.WriteLine(min);
   
        }


    }
}
