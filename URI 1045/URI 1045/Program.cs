using System;

namespace URI_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            float A=0, B=0, C=0;
            
            string[] input = Console.ReadLine().Split();
            float[] numeros = new float[input.Length];
          
            for (int i = 0; i < input.Length; i++) 
            {
                numeros[i] = float.Parse(input[i]);
            }

            if (numeros[0] >= numeros[1] && numeros[0] >= numeros[2]) A = numeros[0];
            else
            if (numeros[1] >= numeros[0] && numeros[1] >= numeros[2]) A = numeros[1];
            else
            if (numeros[2] >= numeros[1] && numeros[2] >= numeros[0]) A = numeros[2];

            for (int i = 0; i < numeros.Length; i++) 
            {
                if (A != numeros[i] && B == 0)
                {
                    B = numeros[i];
                }
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                if (B != numeros[i] && C == 0)
                {
                    C = numeros[i];
                }
            }

            Console.WriteLine(A + " " + B + " " + C);
            
            /*
            if (A >= C + B) Console.WriteLine("NAO FORMA TRIANGULO");
            if (A * A == C * C + B * B) Console.WriteLine("TRIANGULO RETANGULO");
            if (A * A > C * C + B * B) Console.WriteLine("TRIANGULO OBTUSANGULO");
            if (A * A < C * C + B * B) Console.WriteLine("TRIANGULO ACUTANGULO");
            if (A == C && A == B) Console.WriteLine("TRIANGULO EQUILATERO");
            if (A == B && A != C || A == C && A != B) Console.WriteLine("TRIANGULO ISOSCELES");
            */
        }
    }
}
