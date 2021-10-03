using System;

namespace URI_1041
{
    class Program
    {
        static void Main(string[] args)
        {

            float x, y;
            string[] input = Console.ReadLine().Split();

            x = float.Parse(input[0]);
            y = float.Parse(input[1]);
            if(x > 0 && y > 0) Console.WriteLine("Q1");
            else
            if(x < 0 && y > 0) Console.WriteLine("Q2");
            else
            if (x < 0 && y < 0) Console.WriteLine("Q3");
            else
            if (x > 0 && y < 0) Console.WriteLine("Q4");
            else
            if (x == 0 && y == 0) Console.WriteLine("Origem");



        }
    }
}
