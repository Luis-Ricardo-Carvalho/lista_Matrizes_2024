using System;
using Biblioteca_Matriz;

namespace Matrizes
{
    class Exercicio_1_e_2
    {
        static int maiorValorMatriz(int[,] mat) 
        {
            int rows = mat.GetLength(0); //pega linhas
            int cols = mat.GetLength(1); //pega colunas
            int maior = mat[0,0];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    if (mat[i,j]>maior)
                    {
                        maior = mat[i,j];
                    }
                }//fim for j
            }//fim for i
            return maior;

        }
        static void Main()
        {
            int rows, cols;
            Console.WriteLine("Quantidade de linha e colunas:");
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols]; // criando matrix
            Matriz.gera(matrix);
            Console.WriteLine("Matriz Gerada");
            Matriz.mostra(matrix);
            Console.WriteLine($"\nO maior número e {maiorValorMatriz(matrix)}");
            Console.ReadKey();
        }
    }
}
