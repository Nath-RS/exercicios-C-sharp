using System;

namespace URI_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            double total, valor1,valor2;
            int codigo1, quantidade1, codigo2, quantidade2;

            string[] produto = new string[3];
            Console.WriteLine("Digite o codigo do produto 1, a quantidade e o valor de cada unidade na mesma linha separada por espaço");
            produto = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(produto[0]);
            quantidade1 = int.Parse(produto[1]);
            valor1 = double.Parse(produto[2]);
            
            Console.WriteLine("Digite o codigo do produto 2, a quantidade e o valor de cada unidade na mesma linha separada por espaço");
            produto = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(produto[0]);
            quantidade2 = int.Parse(produto[1]);
            valor2 = double.Parse(produto[2]);

            total = (valor1 * quantidade1) + (valor2 * quantidade2);

            Console.WriteLine("Valor total é " + total);

        }
    }
}
