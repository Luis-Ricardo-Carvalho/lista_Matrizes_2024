using System;
using Biblioteca_Matriz;

namespace Matrizes
{
    class Exercicio_4_e_5
    {
        static void diagonalPrincipal(int[,] mat)
        {
            int rows = mat.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{mat[i,i]}|");
            }
            Console.WriteLine();
        }
        static void diagonalSecundaria(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            int j = cols - 1;
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{mat[i,j]}|");
                j--;
            }
            Console.WriteLine();
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
                Console.WriteLine($"Os valores da linha principal são: ");
                diagonalPrincipal(matrix);
                Console.WriteLine($"Os valores da linha secundaria são: ");
                diagonalSecundaria(matrix);
            }
            else
            {
                Console.WriteLine("Não é possível apresentar dados para esta dimensão");
            }

            Console.ReadKey();
        }*/
    }
}