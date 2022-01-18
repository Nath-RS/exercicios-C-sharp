using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            // divisão de números inteiros utilizando soma e subtração

            int dividendo, divisor,quociente,resto;

            dividendo = 5;
            divisor = 2;
            quociente = 0;
            resto = 0;

            while(divisor <= dividendo)
            {
                dividendo = dividendo - divisor;
                quociente++;
                resto = dividendo;
            }

            Console.WriteLine("quociente : " + quociente.ToString());
            Console.WriteLine("resto : " + resto.ToString());
            Console.ReadKey();






            /*
            Console.WriteLine("Divisível");
            divisivel = int.Parse(Console.ReadLine());
            Console.WriteLine("Divisor");
            divisor = int.Parse(Console.ReadLine());

            divisivel = 10;
            divisor = 2;

            if(divisivel % 2 == 0)
            {
               /*
                for(int i = 0; i < divisor; i++)
                {

                }
            
            }
            else
            {
                /*
                for(int i = 0; i < divisor; i++)
                {

                }
            
            }

            Console.WriteLine("resultado da divisão" + resultado);
            
            10 / 2 = 5
            10 + 2 = 12
            12 + 2 = 14
            14 + 2 = 16
            16 - 10 = 6

            8 / 2 = 4
            8 + 2 = 
            
            */



        }
    }
}
