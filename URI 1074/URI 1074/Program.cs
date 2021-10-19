using System;

namespace URI_1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantvalores, valor;
            string[]valores;

            quantvalores = int.Parse(Console.ReadLine());

            valores = new string[quantvalores];

            for(int i=0;i < quantvalores; i++)
            {
                valor = int.Parse(Console.ReadLine());

                if (valor != 0)
                {
                    if (valor % 2 == 0 && valor > 0)
                    {
                        valores[i] = "EVEN POSITIVE";
                    }
                    else if (valor % 2 == 0 && valor < 0)
                    {
                        valores[i] = "EVEN NEGATIVE";
                    }

                    if (valor % 2 != 0 && valor > 0)
                    {
                        valores[i] = "ODD POSITIVE";
                    }
                    else if (valor % 2 != 0 && valor < 0)
                    {
                        valores[i] = "ODD NEGATIVE";
                    }
                }
                else
                {
                    valores[i] = "NULL";
                }

            }

            for(int i = 0; i < quantvalores; i++)
            {
                Console.WriteLine(valores[i]);
            }
        }
    }
}
