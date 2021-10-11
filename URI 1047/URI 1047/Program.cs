using System;

namespace URI_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int iniciohora, iniciominuto, finalhora, finalminuto,horas,minutos;
            
            iniciohora = int.Parse(input[0]);
            iniciominuto = int.Parse(input[1]);
            finalhora = int.Parse(input[2]);
            finalminuto = int.Parse(input[3]);

            horas = finalhora - iniciohora;
            minutos = finalminuto - iniciominuto;

            if (iniciohora == finalhora && iniciominuto == finalminuto)
            {
                Console.WriteLine("O Jogo durou 24 Hora(s) e 0 Minuto(s)");
            }
            else if (minutos < 0 && horas == 1)
            {
                horas--;
                minutos = 59;

                Console.WriteLine("O jogo durou " + horas + " Hora(s) e " + minutos + " Minutos");

            } 
            else Console.WriteLine("O jogo durou " + horas + " Hora(s) e " + minutos + " Minutos");
        }
    }
}
