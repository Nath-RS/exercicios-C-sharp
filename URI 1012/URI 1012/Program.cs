using System;

namespace URI_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = (Console.ReadLine().Split(' '));

            double A = double.Parse(vect[0]), B = double.Parse(vect[1]), C = double.Parse(vect[2]);
            double triangulo = (A * B) / 2.0;
            double circulo = 3.1459 * Math.Pow(C, 2.0);
            double trapezio = ((A + B) * 5.0) / 2.0;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("Triangulo: " + triangulo.ToString("F3"));
            Console.WriteLine("Circulo: " +  circulo.ToString("F3"));
            Console.WriteLine("Trapezio: " + trapezio.ToString("F3"));
            Console.WriteLine("Quadrado: " + quadrado.ToString("N3"));
            Console.WriteLine("Retangulo: " + retangulo.ToString("N3"));

        }
    }
}
