using System;
using System.Globalization;

namespace Matrizes_Questoes_6_e_7
{
    class Program
    {
        static void Main(string[] args)
        {

            // Questão 6
            /*
            int n,escolha_linha,escolha_coluna;
            double soma = 0;
            double[,] matriz,alteraMatriz;
            string[] leitura;

            n = int.Parse(Console.ReadLine());

            matriz = new double[n, n];
            alteraMatriz = new double[n, n];

            for(int i= 0; i < n; i++)
            {
                leitura = Console.ReadLine().Split(' ');

                for(int j= 0; j < n; j++)
                {
                    matriz[i,j] = double.Parse(leitura[j], CultureInfo.InvariantCulture);

                    if(matriz[i,j] > 0)
                    {
                        soma += matriz[i,j];
                    }
                    
                    if(matriz[i,j]< 0)
                    {
                        alteraMatriz[i,j] = matriz[i, j] * matriz[i, j];
                    }
                    else
                    {
                        alteraMatriz[i,j] = matriz[i, j];
                    }
                }
            }

            escolha_linha = int.Parse(Console.ReadLine());
            escolha_coluna = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma dos Positivos: " + soma);

            Console.Write("Linha Escolhida: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(matriz[escolha_linha,i].ToString("N1") + " ");
            }

            Console.Write("\nColuna Escolhida: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i,escolha_coluna].ToString("N1") + " ");
            }

            Console.Write("\nDiagonal Principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i,i].ToString("N1") + " ");
            }
            
            Console.WriteLine("\nMatriz Alterada:");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(alteraMatriz[i,j].ToString("N1") + " ");
                }
                Console.WriteLine();
            }
            */

            int n,m,girarFila;
            int[,] matriz, alteraMatriz;
            string[] leitura;
            
            m= int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            matriz = new int[m, n];
            alteraMatriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                leitura = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(leitura[j]);
                }
            }

            girarFila = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < m; i++)
            {

                girarFila--;
                for (int j = 0; j < n; j++)
                {
                    

                    if (0 == girarFila)
                    {
                        if (j <= 0)
                        {
                            alteraMatriz[i, j] = matriz[i, n - 1];
                            
                        }
                        else
                        {
                            alteraMatriz[i,j] = matriz[i, j - 1];
                        }
                    }
                    else
                    {
                        alteraMatriz[i, j] = matriz[i, j];
                    }
                }
                
            }

            for (int i = 0; i < m; i++)
            {
               

                for (int j = 0; j < n; j++)
                {
                    Console.Write(alteraMatriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
