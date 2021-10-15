using System;

namespace URI_1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int diesel=0, gasolina=0, alcool=0;
            int valor = int.Parse(Console.ReadLine());

            while(valor != 4)
            {
                valor = int.Parse(Console.ReadLine());
                switch (valor)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                }
                
            }

            Console.WriteLine("Muito Obrigado \nAlcool = " + alcool + "\nGasolina = " + gasolina + "\nDiesel = " + diesel);
        }
    }
}
