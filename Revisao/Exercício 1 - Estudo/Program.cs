using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1___Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            string novatentativa;
            float numero1, numero2,total;
            int operacao;
            Console.WriteLine("== Calculadora ==\n 1--\tsubtração\n 2--\tSoma\n 3--\tMultiplicação\n 4--\tDivisão");
            do
            {
                do
                {
                    Console.WriteLine("Qual operação Você Deseja Realizar?");
                    operacao = int.Parse(Console.ReadLine());
                } while (operacao == 0 & operacao < 0 & operacao > 4);

                Console.WriteLine("Digite o Primeiro número : ");
                numero1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Segundo número : ");
                numero2 = float.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        total = numero1 - numero2;
                        Console.WriteLine("O resultado da subtração é " + total);
                        break;
                    case 2:
                        total = numero1 + numero2;
                        Console.WriteLine("O resultado da soma é " + total);
                        break;
                    case 3:
                        total = numero1 * numero2;
                        Console.WriteLine("O resultado da multiplicação é " + total);
                        break;
                    case 4:
                        total = numero1 / numero2;
                        Console.WriteLine("O resultado da Divisão é " + total);
                        break;
                }

                Console.WriteLine("Deseja realizar uma nova operação ? (s/n)");
                novatentativa = Console.ReadLine();

            } while (novatentativa == "s");

            Console.Write("Fim da Execução");
            Console.ReadKey();
        }
    }
}
