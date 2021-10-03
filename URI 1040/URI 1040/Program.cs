using System;

namespace URI_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4;
            string[] input = Console.ReadLine().Split(' ');

            N1 = float.Parse(input[0]);
            N2 = float.Parse(input[1]);
            N3 = float.Parse(input[2]);
            N4 = float.Parse(input[3]);

            float media = (N1 * 0.2f) + (N2 * 0.3f) + (N3 * 0.4f) + (N4 * 0.1f);

            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("N1") + "\nAluno Aprovado");
            }
            else if (media <= 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("N1") + "\nAluno Reprovado");
            }
            else if(media <= 6.9 && media >= 5.0) 
            {
                Console.WriteLine("Media: " + media + "\nAluno em exame");
                float exame = float.Parse(input[4]);
                Console.WriteLine("Nota do exame: " + exame);
                media = (media + exame) / 2;
                
                if(media >= 5.0) Console.WriteLine("Aluno Aprovado");
                else
                if(media < 5.0) Console.WriteLine("Aluno Reprovado");

                Console.WriteLine("Media Final: " + media);

            }

        }
    }
}
