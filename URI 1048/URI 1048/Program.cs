using System;

namespace URI_1048
{
    class Program
    {
        static void Main(string[] args) 
        {
        float salario = float.Parse(Console.ReadLine());


            if (salario > 2000)
            {
                salario += salario * 0.04f;
                Console.WriteLine(salario.ToString("N2"));
            } 
         else if (salario <= 2000 && salario >= 1200.01f)
            {
                salario += salario * 0.07f;
                Console.WriteLine(salario.ToString("N2"));
            }
         else if (salario <= 1200.00f && salario >= 800.01f)
            {
                salario += salario * 0.10f;
                Console.WriteLine(salario.ToString("N2"));
            }
         else if(salario <= 800.00f && salario >= 400.01f)
            {
                salario += salario * 0.12f;
                Console.WriteLine(salario.ToString("N2"));
            }
         else if(salario <= 400.00f && salario >= 0)
            {
                salario += salario * 0.15f;
                Console.WriteLine(salario.ToString("N2"));
            }
        }
    }
}
