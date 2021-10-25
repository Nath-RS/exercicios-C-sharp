using System;

namespace URI_1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max,valor,soma=0;

            string[] leitura = Console.ReadLine().Split(' ');

           valor = int.Parse(leitura[0]);
            min = valor;
            valor = int.Parse(leitura[1]);

                if (valor > min)
                {
                    max = valor;
                }
                else
                {
                    max = min;
                    min = valor;
                }
            if (min > 0)
            {
                for (int i = min; i <= max; i++)
                {
                    soma += i;
                    Console.Write(i + " ");
                }
                Console.WriteLine("Sum = " + soma);
            }
        }
    }
}
