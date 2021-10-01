using System;

namespace URI_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int litroscarro = 12;
            float tempogasto, velocidade;
            double litros;
            
            Console.WriteLine("Digite o tempo gasto na viagem :");
            tempogasto = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a velocidade média: ");
            velocidade = int.Parse(Console.ReadLine());

            litros = (velocidade / litroscarro) * tempogasto;

            Console.WriteLine(litros.ToString("N3") + " litros");
        }
    }
}
