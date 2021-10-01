using System;

namespace URI_1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int carroX = 60, carroY= 90, diferenca = carroY - carroX;
            Console.WriteLine("Digite a distancia(km) :");
            int distancia = int.Parse(Console.ReadLine());

            int tempodistancia = (carroX * distancia)/ diferenca;

            Console.WriteLine(tempodistancia + " minutos.");
            

        }
    }
}
