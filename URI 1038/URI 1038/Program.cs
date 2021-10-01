using System;

namespace URI_1038
{
    class Program
    {

        static void Main(string[] args)
        {
            float[] cod_produto = { 4.00f, 4.50f, 5.00f, 2.00f, 1.50f };
            int X, Y;
            string[] nome_produto = { "Cachorro Quente", "X-Salada", "X-Bacon", "Torrada-Simples", "Refrigerante" };

            string[] input = Console.ReadLine().Split(' ');
            X = int.Parse(input[0]);
            Y = int.Parse(input[1]);

            switch (X) {
                case 1:  
                    Console.WriteLine("Total : R$ " + cod_produto[0]* Y);
                    break;
                case 2:
                    Console.WriteLine("Total : R$ " + cod_produto[1] * Y);
                    break;
                case 3:
                    Console.WriteLine("Total : R$ " + cod_produto[2] * Y);
                    break;
                case 4:
                    Console.WriteLine("Total : R$ " + cod_produto[3] * Y);
                    break;
                case 5:
                    Console.WriteLine("Total : R$ " + cod_produto[4] * Y);
                    break;
            }
            
        }
    }
}
