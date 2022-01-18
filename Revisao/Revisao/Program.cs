using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string nome =  Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Olá " + nome);

           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Feliz Ano Novo!");

            Console.ReadKey();
            */
            int numeroInteiro;

            Console.WriteLine("Digite um número inteiro");
            numeroInteiro=int.Parse(Console.ReadLine());

            Console.Clear();

            
            if(numeroInteiro % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Par");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Impar");
            }

            
            
           

        }
    }
}
