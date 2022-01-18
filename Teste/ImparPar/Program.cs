using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros,impar,par;
            
            numeros = new int[11];
            impar = new int[6];
            par = new int[6];
            
            for(int i = 0; i <= 10; i++)
            {
                numeros[i] = i;
            }

            for(int j = 0;j < 6; j++)
            {
                if(numeros[j] % 2 == 0)
                {
                    par[j] = j;
                }
                else
                {
                    impar[j] = j;
                }
            }
            Console.WriteLine("Numeros Pares :");
            foreach (int x in par)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("Numeros Impares :");
            foreach (int y in impar)
            {
                Console.Write(y + " ");
            }

            Console.ReadKey();
        }
    }
}
