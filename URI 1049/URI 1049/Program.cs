using System;

namespace URI_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada1,entrada2,entrada3;

            entrada1 = Console.ReadLine();
            entrada2 = Console.ReadLine();
            entrada3 = Console.ReadLine();

            if (entrada1 == "vertebrado")
            {
                if(entrada2 == "ave")
                {
                    if(entrada3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (entrada3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                } else if(entrada2 == "mamifero")
                {
                    if (entrada3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (entrada3 == "herbirovo")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if(entrada1 == "invertebrado")
            {
                if (entrada2 == "inseto")
                {
                    if (entrada3 == "hematofato")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (entrada3 == "onivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (entrada2 == "anelideo")
                {
                    if (entrada3 == "hematofato")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (entrada3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

        }
    }
}
