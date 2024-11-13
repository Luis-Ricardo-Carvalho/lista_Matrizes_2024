using System;
class HelloWorld {
    
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
            for (int i = 0;i < linhas; i++)
            {
                for (int j = 0;j < cols; j++)
                {
                    Console.Write($"{mat[i,j],3} |");
                }// fim for j
                Console.WriteLine();
            }// fim for i
        }// fim mostra

  static void Main() {
      
       int rows, cols, rows2, cols2;
            Console.WriteLine("Quantidade de linha e colunas da primeira matriz:");
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols]; // criando matrix
            Console.WriteLine("Quantidade de linha e colunas da segunda matriz:");
            rows2 = int.Parse(Console.ReadLine());
            cols2 = int.Parse(Console.ReadLine());
            int[,] matrix2 = new int[rows2, cols2]; // criando matrix
            
            if (cols == cols2 && rows == rows2)
            {
                gera(matrix);
                
                gera(matrix2);
                
                
                Console.WriteLine("Escolha a operacao (a) somar as duas matrizes (b) subtrair a primeira matriz da segunda (c) adicionar uma constante as duas matrizes (d) imprimir as matrizes.");
                String operacao = Console.ReadLine();
                
                if(operacao == "a"){
                    
                    Console.WriteLine("Matriz 1");
                    mostra(matrix);
                    Console.WriteLine("Matriz 2");
                    mostra(matrix2);
                    
                    int[,] matrix3 = new int[rows2, cols2];
                    for (int i = 0;i < rows2; i++)
                    {
                        for (int j = 0;j < cols2; j++)
                        {
                            matrix3[i,j] = matrix[i,j] + matrix2[i,j];
                        
                        }// fim for j
                    }// fim for i
                    

                    Console.WriteLine("Matriz Soma");
                    mostra(matrix3);
                    
                } else if (operacao == "b"){
                    
                    Console.WriteLine("Matriz 1");
                    mostra(matrix);
                    Console.WriteLine("Matriz 2");
                    mostra(matrix2);
                    
                    int[,] matrix3 = new int[rows2, cols2];
                    for (int i = 0;i < rows2; i++)
                    {
                        for (int j = 0;j < cols2; j++)
                        {
                            matrix3[i,j] = matrix2[i,j] - matrix[i,j];
                        
                        }// fim for j
                    }// fim for i
                    

                    Console.WriteLine("Matriz Subtrair");
                    mostra(matrix3);
                    
                } else if (operacao == "c"){
                    
                    Console.WriteLine("Matriz 1");
                    mostra(matrix);
                    Console.WriteLine("Matriz 2");
                    mostra(matrix2);
                    
                    Console.WriteLine("Escolha o valor contante par adicionar");
                    int constante = int.Parse(Console.ReadLine());
                    
                    for (int i = 0;i < rows2; i++)
                    {
                        for (int j = 0;j < cols2; j++)
                        {
                            matrix[i,j] = matrix[i,j] + constante;
                            matrix2[i,j] = matrix2[i,j] + constante;
                        
                        }// fim for j
                    }// fim for i
                    
                    
                    Console.WriteLine("Matriz 1 com o constante");
                    mostra(matrix);
                    Console.WriteLine("Matriz 2 com o constante");
                    mostra(matrix2);
                    
                } else if (operacao == "d"){
                    
                    Console.WriteLine("Matriz 1");
                    mostra(matrix);
                    Console.WriteLine("Matriz 2");
                    mostra(matrix2);
                    
                } else{
                    Console.WriteLine($"Não é possível apresentar dados porque não existe a operacao:{operacao}");
                }
            }
            else
            {
                Console.WriteLine("Não é possível apresentar dados porque as matrizes não são iguais");
            }

    
    
  }
}
