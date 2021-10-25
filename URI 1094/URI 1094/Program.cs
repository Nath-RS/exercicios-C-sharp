using System;

namespace URI_1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int leitura1;
            string leitura2;
            int coelhos,sapos,ratos,total,change;

            total = 0;ratos = 0;coelhos = 0;sapos = 0;
            change = int.Parse(Console.ReadLine());

            for(int i = 0;i <= change; i ++)
            {
                leitura1 = int.Parse(Console.ReadLine()); 
                leitura2 = Console.ReadLine();
                
                if(leitura2 == "C")
                {
                    Console.WriteLine("Coelho");
                    coelhos += leitura1;
                }
                else if(leitura2 == "R")
                {
                    Console.WriteLine("Rato");
                    ratos += leitura1;
                }
                else if(leitura2 == "S")
                {
                    Console.WriteLine("Sapo");
                    sapos += leitura1;
                }

                
            }

            total = sapos + ratos + coelhos;

            Console.WriteLine("TOTAL de " + total + " cobaias");
            Console.WriteLine("TOTAL de " + coelhos + " coelhos");
            Console.WriteLine("TOTAL de " + ratos + " ratos");
            Console.WriteLine("TOTAL de " + sapos + " sapos");
            Console.WriteLine("Percentual de coelhos: " + ((coelhos*100)/total) + "%");
            Console.WriteLine("Percentual de ratos: " + ((ratos * 100) / total) + "%");
            Console.WriteLine("Percentual de sapos: " + ((sapos * 100) / total) + "%");


        }
    }
}
