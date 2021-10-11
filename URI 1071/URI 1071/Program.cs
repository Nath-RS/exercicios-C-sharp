using System;

namespace URI_1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int y=0,acum = 0,leitura,leitura2;

            leitura = int.Parse(Console.ReadLine());
            leitura2 = int.Parse(Console.ReadLine());

            do
            {
                if (leitura < leitura2)
                {
                    for (y = leitura; y < leitura2; y++)
                    {
                        if (y % 2 != 0)
                        {
                            acum += y;
                        }


                    }
                }

                if (leitura > leitura2)
                {
                    for (y = leitura; y < leitura2; y--)
                    {
                        if (y % 2 != 0)
                        {
                            acum += y;
                        }


                    }
                }
            } while (y == leitura || y == leitura2);
            Console.WriteLine(acum);
        }
    }
}
