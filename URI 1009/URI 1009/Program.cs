using System;

namespace URI_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            float salarioFixo = float.Parse(Console.ReadLine());
            float vendaTotal = float.Parse(Console.ReadLine());

            double bonus = (vendaTotal * 0.15) + salarioFixo;

            Console.WriteLine("Total = R$ " + bonus.ToString("N2"));
        }
    }
}
