using System;

namespace URI_1051
{
    class Program
    {
        static void Main(string[] args)
        {
            float entrada,taxa;

            entrada = float.Parse(Console.ReadLine());

            if (entrada <= 2000.00 && entrada > 0) 
            {
                Console.WriteLine("Without taxes");
            }
            else if(entrada >= 2000.01 && entrada < 3000.00)
            {
                taxa = 1000 * 0.08f;
                Console.WriteLine("R$" + taxa.ToString("N2"));
            }
            else if(entrada >= 3000.01 && entrada < 4500.00)
            {
                taxa = entrada * 0.18f;
                Console.WriteLine("R$" + taxa.ToString("N2"));
            }
            else if(entrada > 4500.00)
            {
                taxa = entrada * 0.28f;
                Console.WriteLine("R$" + taxa.ToString("N2"));
            }
        }
    }
}
