using System;

namespace URi_1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, valor,total=0;
            string[] leitura = Console.ReadLine().Split(' ');
            
            if(leitura.Length == 2)
            {
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
                for (int i = min+1; i < max;i++)
                {
                    if(i % 2 != 0)
                    {
                        total += i;   
                    }
                }

            }
            Console.WriteLine(total);




        }
    }
}
