using System;

namespace URI_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            float input = float.Parse(Console.ReadLine());

            if(input > 0 && input < 25)     Console.WriteLine("Intervalo [0,25]");
            else 
                if (input > 25 && input < 50)   Console.WriteLine("Intervalo [25,50]");
            else
                if (input > 50 && input < 75) Console.WriteLine("Intervalo [50,75]");
            else
                if (input > 25 && input < 50) Console.WriteLine("Intervalo [75,100]");
            else
                if (input > 100 || input < 0) Console.WriteLine("Fora do Intervalo");
        }
    }
}
