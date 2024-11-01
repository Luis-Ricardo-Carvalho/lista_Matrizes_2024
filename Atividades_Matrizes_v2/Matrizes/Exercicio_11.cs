using System;
using Biblioteca_Matriz;

namespace Matrizes
{
    class Exercicio_11
    {
        static int diagonalPrincipal(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int soma = 0;
            for (int i = 0; i < rows; i++)
            {
                /*Console.Write($"{mat[i, i]}|");*/
                soma = soma + mat[i, i];

            }
            Console.WriteLine();
            return soma;
        }
        static int diagonalSecundaria(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            int j = cols - 1;
            int soma = 0;
            for (int i = 0; i < rows; i++)
            {
                /*Console.Write($"{mat[i, j]}|");*/
                soma = soma + mat[i, j];
                j--;
            }
            Console.WriteLine();
            return soma;
        }
        /*static void Main()
        {
            int rows, cols;
            Console.WriteLine("Quantidade de linha e colunas:");
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols]; // criando matrix
            if (cols == rows)
            {
                Matriz.gera(matrix);
                Matriz.mostra(matrix);
                Console.WriteLine("Matriz Gerada");
                Console.WriteLine($"Os valores da linha principal são: {diagonalPrincipal(matrix)}");
                Console.WriteLine($"Os valores da linha secundaria são: {diagonalSecundaria(matrix)}");
                if (diagonalSecundaria(matrix) > diagonalPrincipal(matrix))
                {
                    Console.WriteLine("O maior tesouro está na diagonal secundária, vamos para lá!");
                }
                else
                {
                    Console.WriteLine("O maior tesouro está na principal secundária, vamos para lá!");

                }
            }
            else
            {
                Console.WriteLine("Não é possível apresentar dados para esta dimensão");
            }

            Console.ReadKey();
        }*/
    }
}
