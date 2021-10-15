using System;

namespace URI_1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, leitura,numeroacum,total;
            cont = 1;

            leitura = int.Parse(Console.ReadLine());
            
            if (leitura % 2 == 0)
            {
                numeroacum = leitura;
                total = numeroacum;
            }
            else
            {
                numeroacum = ++leitura;
                total = numeroacum;
            }
                while (cont < 5)
                {
                cont++;
                numeroacum += 2;
                total += numeroacum;
                }
            Console.WriteLine(total);
        }

    }
}
