using System;
using System.Runtime.Serialization;

class atividade0711
{
    public static void gera(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int cols = mat.GetLength(1);
        Random random = new Random();
        for (int i = 0; i < linhas; i++)
            for (int j = 0; j < cols; j++)
                mat[i, j] = random.Next(0,100);

    }// fim gera
        
    public static void mostra(int[,] mat) {
        int linhas = mat.GetLength(0);
        int cols = mat.GetLength(1);
        
        Console.Write("Matriz das Tropas (Quantidade de Tropas por Cidade):\n");
        for (int i = 0;i < linhas; i++)
        {
            
            Console.Write("Região "+(i+1)+":");
            for (int j = 0;j < cols; j++)
            {
                    Console.Write($"{mat[i,j],3} ");
            }// fim for j
                Console.WriteLine();
        }// fim for i
    }// fim mostra

    static void Main()
    {

        int[,] matriz = new int[3,3];

        gera(matriz);

        mostra(matriz);


        for (int i = 0; i < 3; i++){

            int soma = 0;

                   Console.WriteLine("\nRegião "+(i+1)+":");

                for (int j = 0; j < 3; j++)
                {

                soma = soma + matriz[i,j];


                }


            Console.WriteLine("Tropas: "+soma);   

        }

    }
}
