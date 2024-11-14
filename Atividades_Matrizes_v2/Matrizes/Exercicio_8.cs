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
                mat[i, j] = random.Next(0,5);

    }// fim gera
        
    public static void mostra(int[,] mat) {
        int linhas = mat.GetLength(0);
        int cols = mat.GetLength(1);
        
        for (int i = 0;i < linhas; i++)
        {
            for (int j = 0;j < cols; j++)
            {
                    Console.Write($"{mat[i,j],3} ");
            }// fim for j
                Console.WriteLine();
        }// fim for i
    }// fim mostra

    static void Main()
    {

        int cont =0;
        Console.WriteLine("Quantidade de Veses que o codigo vai rodar");
        int rows = int.Parse(Console.ReadLine());
        int[,] matriz = new int[rows,2];

        gera(matriz);

        mostra(matriz);


        for (int i = 0; i < rows; i++){



                for (int i2 = 0; i2 < rows; i2++){

                        if(matriz[i,0] == matriz[i2,0] && matriz[i,1] == matriz[i2,1] ){
                                cont ++;
                        }

                }


        }
        
            
            if(cont > rows){
                
            Console.WriteLine("1");  
            }
            else{
            Console.WriteLine("0 ");  
            }

    }
}
