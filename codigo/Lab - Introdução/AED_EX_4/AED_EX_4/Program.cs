using System;

namespace AED_EX_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = GetMatriz();
            PrintLinSum(matriz);
            PrintColSum(matriz);
            Console.ReadKey();
        }

        static void PrintLinSum(int[,] matriz)
        {
            Console.WriteLine("Exibindo soma de todas as colunas da matriz: ");
            for (int lin = 0; lin < 5; lin++)
            {
                int sum = 0;
                for (int col = 0; col < 3; col++)
                {
                    sum += matriz[col, lin];
                }
                string message = string.Format("A soma de valores da linha {0} é {1}: ", lin+1, sum);
                Console.WriteLine(message);
            }
            Console.WriteLine();
        }

        static void PrintColSum(int[,] matriz)
        {
            Console.WriteLine("Exibindo soma de todas as colunas da matriz: ");
            for (int col = 0; col < 3; col++)
            {
                int sum = 0;
                for (int lin = 0; lin < 5; lin++)
                {
                    sum += matriz[col, lin];
                }
                string message = string.Format("A soma de valores da coluna {0} é {1}: ", col+1, sum);
                Console.WriteLine(message);
            }
            Console.WriteLine();
        }

        static int[,] GetMatriz()
        {
            int[,] matriz = new int[3,5];

            for(int col = 0; col < 3; col++)
            {
                for(int lin = 0; lin < 5; lin ++)
                {
                    string message = String.Format("Informe o número na posição col {0}, lin {1}: ", col + 1, lin + 1);
                    Console.WriteLine(message);
                    matriz[col, lin] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
            }  

            return matriz;
        }

    }
}
