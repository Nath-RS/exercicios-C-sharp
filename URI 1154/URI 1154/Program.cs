using System;

namespace URI_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade,leitura;
            double acumulo,cont;

            leitura = int.Parse(Console.ReadLine());
            idade = leitura;
            cont = 1.00;

            while (leitura > 0)
            {
                leitura = int.Parse(Console.ReadLine());
                if (leitura > 0)
                {
                    idade += leitura;
                    cont+= 1.00;
                }
            }
            acumulo = idade / cont;
            Console.WriteLine(acumulo);

        }
    }
}
