using System;

namespace URI_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int maiorAB, maiorABC;
            string[] ABC = new string[3];

            ABC = Console.ReadLine().Split(' ');

            maiorAB = (int.Parse(ABC[0]) + int.Parse(ABC[1]) + Math.Abs(int.Parse(ABC[0]) - int.Parse(ABC[1])))/2;
            maiorABC = (maiorAB + int.Parse(ABC[2]) + Math.Abs(maiorAB - int.Parse(ABC[2]))) / 2;

            Console.WriteLine(maiorABC + " é o Maior!");
        }
    }
}
