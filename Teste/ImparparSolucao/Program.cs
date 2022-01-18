using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparparSolucao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] par = new int[5];
            int[] impar = new int[5];
            int P = 0;
            int M = 0;


            for(int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    par[P] = i;
                    P = P + 1;
                }
                else
                {
                    impar[M] = i;
                    M = M + 1;
                }

            }
            
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(par[i]);
            }

            Console.WriteLine();
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(impar[i]);
            }

            Console.ReadKey();
        }

    }
}
