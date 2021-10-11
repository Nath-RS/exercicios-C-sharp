using System;
using System.Globalization;

namespace URi_1117
{
    class Program
    {
        static void Main(string[] args)
        {
            bool chave = false;
            while (chave == false)
            {
                double leitura,leitura2;
                string l = Console.ReadLine();
                if (l == "")
                {
                    leitura = 0;
                }
                else
                {
                    leitura = double.Parse(l, CultureInfo.InvariantCulture);
                }

                if (leitura > 0)
                {
                    l = Console.ReadLine();
                    if (l == "")
                    {
                        leitura2 = 0;
                    }
                    else
                    {
                        leitura2 = double.Parse(l, CultureInfo.InvariantCulture);
                    }
                    

                    if (leitura2 > 0)
                    {
                        double media =(leitura + leitura2)/2.00;
                        chave = true;
                        Console.WriteLine("Media = " + media.ToString("N2"));
                    }
                    else
                        Console.WriteLine("nota invalida");
                }
                else
                    Console.WriteLine("nota invalida");

            }
        }
    }
}
