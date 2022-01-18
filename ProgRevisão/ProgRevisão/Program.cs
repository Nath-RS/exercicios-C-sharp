using System;
using System.Globalization;
namespace ProgRevisão
{
    class Program
    {
        static void Main(string[] args)
        {
            double hipotenusa, catetoop, catetoadj;

            Console.WriteLine("== Calculo da Hiputenusa utilizando método de Pitágoras ==");

            Console.WriteLine("Primeiro Cateto ");
            catetoop = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Cateto");
            catetoadj = double.Parse(Console.ReadLine());

            Console.WriteLine("Formula da operação = A*A = B*B - C*C");
            _ = Console.ReadLine();
            Console.WriteLine("B*B = " + Math.Pow(catetoop,2));
            _ = Console.ReadLine();
            Console.WriteLine("C*C =" + Math.Pow(catetoadj, 2));

            hipotenusa = Math.Sqrt(Math.Pow(catetoop, 2) + Math.Pow(catetoadj, 2));

            Console.WriteLine("A*A = " + (Math.Pow(catetoop, 2) + Math.Pow(catetoadj, 2)));

            Console.WriteLine("A = "+ hipotenusa.ToString("F1",CultureInfo.InvariantCulture));
        }


    }
}
