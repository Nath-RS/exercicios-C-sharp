using System;

namespace URI_1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int leitura = int.Parse(Console.ReadLine());
            
            for(int i = 0; i <= leitura; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
