using System;

namespace URI_1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2,media;
            string leitura;
            do
            {



                do
                {
                    leitura = Console.ReadLine();
                    if (leitura == "")
                    {
                        leitura = "-3";
                    }

                    nota1 = float.Parse(leitura);
                    if (nota1 < 0) Console.WriteLine("Nota Invalida");
                } while (nota1 < 0);

                do
                {
                    leitura = Console.ReadLine();
                    if (leitura == "")
                    {
                        leitura = "-3";
                    }
                    nota2 = float.Parse(leitura);
                    if (nota2 < 0) Console.WriteLine("Nota Invalida");
                } while (nota2 < 0);

                media = (nota1 + nota2) / 2.00;

                Console.WriteLine("Média é " + media);
                Console.WriteLine("novo calculo 1--Sim 2--Não");
                leitura = Console.ReadLine();
            } while (leitura == "1");

        }
    }
}
