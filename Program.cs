using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string [] args)
        {
            //Declarando minha variavel n
            int n = int.Parse(Console.ReadLine());
            

            int[,] mat = new int[n, n];
            
            //declarando a matrizes
            for (int i = 0; i < n; i++) 
            {
                string[] values = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
           
                }

            }
            //coloca em coluna

            Console.WriteLine("Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
             
           //executa o calculo 
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
             //mostra o resultado dos numeros negativos
                            Console.WriteLine("Números negativos: " + count);
        }
    }
}
