using System;

namespace URI_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            float y;
            double km;
            Console.WriteLine("Digite a distancia percorrida em metros :");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto de combustível você gastou?");
            y = float.Parse(Console.ReadLine());
            km = x / y;

            Console.WriteLine(km.ToString("N3") + " km/h");

        }
    }
}
