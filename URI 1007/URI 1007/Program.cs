using System;

namespace URI_1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado;
            int[] vet = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite " + (i + 1) + "° numero:");
                vet[i] = int.Parse(Console.ReadLine());
            }

            resultado = (vet[0] * vet[1]) - (vet[2] * vet[3]);
            Console.WriteLine("O resulta é " + resultado);    
        }
    }
}
