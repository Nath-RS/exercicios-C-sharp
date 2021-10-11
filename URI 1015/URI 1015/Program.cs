using System;

namespace URI_1015
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] cordenadaString = new string[2];
            float[] cordenada1 = new float[2];
            float[] cordenada2 = new float[2];

            double distancia; 
            
            // Cordenada do ponto 1
            cordenadaString = Console.ReadLine().Split(' ');
            for (int i = 0; i < cordenadaString.Length; i++)
            {
                cordenada1[i] = float.Parse(cordenadaString[i]);
            }
            // Cordenada do ponto 2
            cordenadaString = Console.ReadLine().Split(' ');
            for (int i = 0; i < cordenadaString.Length; i++)
            {
                cordenada2[i] =float.Parse(cordenadaString[i]);
            }
            //calculo
            distancia = Math.Sqrt(Math.Pow((cordenada2[0] - cordenada1[0]),2.0) + Math.Pow((cordenada2[1] - cordenada1[1]), 2.0));

            Console.WriteLine(distancia.ToString("N4"));

        }
    }
}
