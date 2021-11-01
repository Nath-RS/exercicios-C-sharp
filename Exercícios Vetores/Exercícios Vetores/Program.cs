using System;

namespace Exercícios_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício1
            /* Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número
            do vetor(supor não haver empates).Mostrar também a posição do maior elemento.
        
            int n,posicao=default;
            double[] vetor;
            double maior=0;
            string leitura;

            leitura = Console.ReadLine();
            n = int.Parse(leitura);
            vetor = new double[n];

            for(int i= 0; i < n; i++)
            {
                leitura = Console.ReadLine();

                vetor[i] = double.Parse(leitura);
                
                if(maior == 0)
                {
                    maior = vetor[i];
                }
                else if(vetor[i] >= maior)
                {
                    maior = vetor[i];
                }
            }

            Console.WriteLine(maior);

            for (int i = 0; i < n; i++)
            {
                if(vetor[i] == maior)
                {
                    posicao = i;
                }
            }
            Console.WriteLine(posicao);
            */

            //Exercício2
            /* Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
                - todos os números pares
                - a quantidade de números pares
            

            int pares = 0, n;
            int[] vetor;

            n = int.Parse(Console.ReadLine());
            vetor = new int[n];

            for(int i = 0; i < n; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for(int i= 0; i < n; i++)
            {
                if(vetor[i] % 2 == 0)
                {
                    Console.Write(vetor[i]+" ");
                    pares++;
                }
            }
            Console.WriteLine("\n" + pares);
            */

            //Exercício3
            /*Faça um programa para ler dois vetores A e B, contendo N elementos cada. Em seguida, gere um terceiro vetor C onde
cada elemento de C é a soma dos elementos correspondentes de A e B. Imprima o vetor C gerado.
            

            int[] a, b, c;
            string[] leitura;
            int n;

            n = int.Parse(Console.ReadLine());
            a = new int[n];
            b = new int[n];
            c = new int[n];

            for(int i = 0;i < 2; i++)
            {
                leitura = Console.ReadLine().Split(' ');

                if (a[0] == 0 &  a[1]== 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        a[j] = int.Parse(leitura[j]);
                    }
                }
                else
                {
                    for (int j = 0; j < n; j++)
                    {
                        b[j] = int.Parse(leitura[j]);
                    }
                }

            }
            for(int i = 0;i<c.Length;i++)
            {
                c[i] = a[i] + b[i];
            }

            foreach (int elemento in c)
            {
                Console.Write(elemento + " ");
            }
            */

            //Exercício4
            /*Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar na tela a média aritmética de todos
elementos. Depois mostrar todos os elementos do vetor que estejam abaixo da média.
            

            int n;
            double[] vetornumeros;
            string[] leitura;
            double soma=0, media;

            n = int.Parse(Console.ReadLine());
            vetornumeros = new double[n];

            leitura = Console.ReadLine().Split(' ');
            
            for(int i = 0; i < n; i++)
            {
                vetornumeros[i] = double.Parse(leitura[i]);
            }

            foreach(double item in vetornumeros)
            {
                soma += item;
            }

            media = soma / n;

            Console.WriteLine(media.ToString("N3"));
            
            foreach(double item in vetornumeros)
            {
                if(item < media)
                {
                    Console.WriteLine(item);
                }
            }
            */


            //Exercício5
            /*Fazer um programa para ler um vetor de N números inteiros. Em seguida, mostrar na tela a média aritmética somente
dos números pares lidos.
            

            int n, pares = 0, soma = 0;
            int[] vetornumeros;
            string[] leitura;
            double media;

            n = int.Parse(Console.ReadLine());
            vetornumeros = new int[n];

            leitura = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vetornumeros[i] = int.Parse(leitura[i]);
            }

            foreach(int item in vetornumeros)
            {
                if(item % 2 == 0)
                {
                    soma += item;
                    pares++;
                }
            }
            media = soma / pares;

            Console.WriteLine(media);
            */

            //Exercício6
            /*Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Depois, mostrar na tela o nome
da pessoa mais velha.
            

            string[] leitura, nomes;
            int[] idade;
            int tamanho, maioridade = 0;
            string nome = "";

            tamanho = int.Parse(Console.ReadLine());

            idade = new int[tamanho];
            nomes = new string[tamanho];

            for(int i = 0; i < tamanho; i++)
            {
                leitura = Console.ReadLine().Split(' ');

                nomes[i] = leitura[0];
                idade[i] = int.Parse(leitura[1]);
            }
            for(int i = 0; i < tamanho; i++)
            {
                if(idade[i] > maioridade)
                {
                    maioridade = idade[i];
                    nome = nomes[i];
                }
            }
            Console.WriteLine(nome);
            */

            //Exercício7
            /* Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres.
Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir os nomes dos alunos aprovados,
considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.
            
            string[] leitura, nomes;
            int n;
            double[] nota1, nota2, media;

            n = int.Parse(Console.ReadLine());

            nota1 = new double[n];
            nota2 = new double[n];
            nomes = new string[n];
            media = new double[n];

            for (int i = 0; i < n; i++)
            {
                leitura = Console.ReadLine().Split(' ');

                nomes[i] = leitura[0];
                nota1[i] = double.Parse(leitura[1]);
                nota2[i] = double.Parse(leitura[2]);
                media[i] = (nota1[i] + nota2[i]) / 2.0;
            }

           for(int i = 0; i < n; i++)
            {
                if(media[i] >=  6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
           */

        }
    }
}
