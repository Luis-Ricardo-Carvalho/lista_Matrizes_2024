using System;
using Biblioteca_Matriz;
namespace Matrizes
{/*Crie uma função que receba uma matriz N por M e conte quantos números iguais a X existem na matriz. X
deve ser informado pelo usuário (parâmetro da função). Retorne a quantas ocorrências de X existem na
matriz.*/
    class Exercicio_3
    {
        static int numeroValorMatriz(int[,] mat,int num1)
        {
            int rows = mat.GetLength(0); //pega linhas
            int cols = mat.GetLength(1); //pega colunas
            int cont = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mat[i, j] == num1)
                    {
                        cont++;
                    }
                }//fim for j
            }//fim for i
            return cont;

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
            Console.WriteLine("Digite um número");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Esse número apareceu: {numeroValorMatriz(matrix, num)} vez(es)");

            Console.ReadKey();
        }
    }
}
