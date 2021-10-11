using System;

namespace URI_1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002,leitura;

            leitura = int.Parse(Console.ReadLine());
            while (senha != leitura) {

                Console.WriteLine("Senha Invalida");
                leitura = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");

        }
    }
}
