using System;

namespace URI_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFuncionario, horasTrabalhadas;
            float salarioHora;

            Console.WriteLine("Digite o numero do funcionario: ");
            nFuncionario = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Digite o numero de Horas trabalhadas no mês: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor recebido por horas trabalhadas: ");
            salarioHora = float.Parse(Console.ReadLine());

            Console.WriteLine("\nNumero do funcionario = " + nFuncionario);
            Console.WriteLine("Salário = R$ " + (salarioHora * horasTrabalhadas));
        }
    }
}
