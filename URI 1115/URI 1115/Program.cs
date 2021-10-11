using System;

namespace URI_1115
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] leitura = Console.ReadLine().Split(' ');

            if (leitura.Length != 0 && leitura.Length != 1)
            {
                x = int.Parse(leitura[0]);
                y = int.Parse(leitura[1]);

                while (leitura.Length != 0 && leitura.Length != 1)
                {
                    
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("Primeiro quadrante");
                    }
                    else if (x < 0 && y > 0)
                    {
                        Console.WriteLine("Segundo Quadrante");
                    }
                    else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("Terceiro Quadrante");
                    }
                    else if (x > 0 && y < 0)
                    {
                        Console.WriteLine("Quarto quadrante");
                    }

                    leitura = Console.ReadLine().Split(' ');
                    if (leitura.Length != 0 && leitura.Length != 1)
                    {
                        x = int.Parse(leitura[0]);
                        y = int.Parse(leitura[1]);
                    }
                }
            }
        }
    }
}
