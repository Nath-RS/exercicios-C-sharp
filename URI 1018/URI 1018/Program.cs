using System;

namespace URI_1018
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor;
            int notas100, resto100;
            int notas50, resto50;
            int notas20, resto20;
            int notas10, resto10;
            int notas5, resto5;
            int notas2, resto2;
            int notas1, resto1;

            valor = int.Parse(Console.ReadLine());

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

            notas1 = resto2 / 1;
            resto1 = resto2 % 1;

            Console.WriteLine(notas100 +" Nota(s) de 100 reais");
            Console.WriteLine(notas50 + " Nota(s) de 50 reais");
            Console.WriteLine(notas20 + " Nota(s) de 20 reais");
            Console.WriteLine(notas10 + " Nota(s) de 10 reais");
            Console.WriteLine(notas5 + " Nota(s) de 5 reais");
            Console.WriteLine(notas2 + " Nota(s) de 2 reais");
            Console.WriteLine(notas1 + " Nota(s) de 1 reais");


        }
    }
}
