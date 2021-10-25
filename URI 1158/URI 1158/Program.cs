using System;

namespace URI_1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, inicial, repetição,contador = 0;

            string[] leitura = Console.ReadLine().Split(' ');

            inicial = int.Parse(leitura[0]);
            repetição = int.Parse(leitura[1]);
            int i = inicial;

            while (contador < repetição)
            { 
                if(i % 2 != 0)
                {
                    soma += i;
                    contador++;
                }

                i++;
            }
            Console.WriteLine(soma);
        }
    }
}
