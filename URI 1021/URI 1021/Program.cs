using System;

namespace URI_1021
{
    class Program
    {
        static void Main(string[] args)
        {

            float valor;
            float notas100, resto100;
            float notas50, resto50;
            float notas20, resto20;
            float notas10, resto10;
            float notas5, resto5;
            float notas2, resto2;
            //Moedas
            float moedas1R, resto1;
            float moedas50, resto50m;
            float moedas25, resto25m;
            float moedas10, resto10m;
            float moedas5, resto5m;
            double moedas1, resto1m;

            valor = float.Parse(Console.ReadLine());

            notas100 = valor / 100;
            resto100 = valor % 100;

            notas50 = resto100 / 50;
            resto50 = resto100 % 50;

            notas20 = resto50 / 20;
            resto20 = resto50 % 20;

            notas10 = resto20 / 10;
            resto10 = resto20 % 10;

            notas5 = resto10 / 5;
            resto5 = resto10 % 5;

            notas2 = resto5 / 2;
            resto2 = resto5 % 2;

            moedas1R = resto2 / 1;
            resto1 = resto2 % 1;

            moedas50 = resto1 / 0.50f;
            resto50m = resto1 % 0.50f;

            moedas25 = resto50m / 0.25f;
            resto25m = resto50m % 0.25f;

            moedas10 = resto25m / 0.10f;
            resto10m = resto25m % 0.10f;

            moedas5 = resto10m / 0.05f;
            resto5m = resto10m % 0.05f;

            moedas1 =  Math.Round(resto5m / 0.01f);

            Console.WriteLine((int)notas100 + " Nota(s) de 100 reais");
            Console.WriteLine((int)notas50 + " Nota(s) de 50 reais");
            Console.WriteLine((int)notas20 + " Nota(s) de 20 reais");
            Console.WriteLine((int)notas10 + " Nota(s) de 10 reais");
            Console.WriteLine((int)notas5 + " Nota(s) de 5 reais");
            Console.WriteLine((int)notas2 + " Nota(s) de 2 reais");
           
            Console.WriteLine("Moedas:");
            Console.WriteLine((int)moedas1R + " Moeda(s) de 1 real");
            Console.WriteLine((int)moedas50 + " Moeda(s) de 50 centavos");
            Console.WriteLine((int)moedas25 + " Moeda(s) de 25 centavos");
            Console.WriteLine((int)moedas10 + " Moeda(s) de 10 centavos");
            Console.WriteLine((int)moedas5 + " Moeda(s) de 5 centavos");
            Console.WriteLine((int)moedas1 + " Moeda(s) de 1 centavo");

        }
    }
}
