using System;

namespace URI_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.1459;
            float raio;
            double resultado;

            raio = float.Parse(Console.ReadLine());

            resultado =(float) (4.0 / 3) * pi * Math.Pow(raio, 3.0);
            Console.WriteLine("Volume = "+resultado.ToString("N3"));
        }
    }
}
