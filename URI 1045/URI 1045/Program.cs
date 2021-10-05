using System;

namespace URI_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            float A=0, B=0, C=0;
            bool forma = true;

            
            string[] input = Console.ReadLine().Split();
            float[] numeros = new float[input.Length];
          
            for (int i = 0; i < input.Length; i++) 
            {
                numeros[i] = float.Parse(input[i]);
            }

            if (numeros[0] >= numeros[1] && numeros[0] >= numeros[2])
            {
                A = numeros[0]; B = numeros[1]; C = numeros[2];
            }
            else if (numeros[1] >= numeros[0] && numeros[1] >= numeros[2])
            {
                A = numeros[1]; B = numeros[0]; C = numeros[2];
            }
            else if (numeros[2] >= numeros[1] && numeros[2] >= numeros[0])
            {
                A = numeros[2]; B = numeros[0]; C = numeros[1];
            }

            if (A >= C + B)
            {
                Console.WriteLine("NAO FORMA TRIANGULO"); forma = false;
            }
            if (forma == true && A * A == C * C + B * B) Console.WriteLine("TRIANGULO RETANGULO");
            if(forma == true && A * A > C * C + B * B) Console.WriteLine("TRIANGULO OBTUSANGULO");
            if (forma == true && A * A < C * C + B * B) Console.WriteLine("TRIANGULO ACUTANGULO");
            if (forma == true && A == C && A == B) Console.WriteLine("TRIANGULO EQUILATERO");
            if (forma == true && A == B && A != C || A == C && A != B || B == C && B != A) Console.WriteLine("TRIANGULO ISOSCELES");
            
        }
    }
}
