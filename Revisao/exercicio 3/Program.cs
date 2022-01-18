using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string frase;
            int total,cont;

            Console.WriteLine("Digite uma Frase: ");

            frase = Console.ReadLine();

            total = frase.Length;
            cont = 0;

            if (frase.Trim().Length > 0)
            {
                while(cont < total)
                {
                    
                    if(frase[cont] == 'a')
                    {
                        Console.Write('&');
                    }
                    else
                    {
                        Console.Write(frase[cont]);
                    }

                    cont++;
                }
            }
            else
            {
                Console.WriteLine("Esta Frase não possui Caracteres");
            }

            Console.ReadKey();
            */


            double salario,ajuste,novoSalario;

            Console.WriteLine("Digite seu Salario: ");
            salario = double.Parse(Console.ReadLine());

            if(salario < 1700)
            {
                ajuste = 300.00;
                novoSalario = salario + ajuste;
            }
            else
            {
                ajuste = 200.00;
                novoSalario = salario + ajuste;
            }

            Console.WriteLine("Novo Salário: " + novoSalario);

            Console.ReadKey();
        }
    }
}
