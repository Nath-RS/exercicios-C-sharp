using System;

namespace URI_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, meses, dias;
            int valor;

            valor = int.Parse(Console.ReadLine());

            anos = valor / 365;
            meses = (valor % 365) / 30;
            dias = ((valor % 365) % 30);
            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
