using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado;
            resultado = processar();

            Console.WriteLine(resultado);
            Console.ReadKey();
        }

        public static string processar()
        {
            int idade;
            Console.WriteLine("Digite Sua idade: ");

            idade = int.Parse(Console.ReadLine());

            if (idade < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "Sem Permissão!";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return "Permissão Concedida!";
            }
        }
    }
}
