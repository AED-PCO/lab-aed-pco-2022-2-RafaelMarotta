using System;

namespace BINARY_SEARCH_SEM_AUX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = getArray();
            int n = getSearchN();
            try
            {
                int pos = BinarySearch(arr, n, 0, arr.Length - 1);
                Console.WriteLine(string.Format("A posição do número {0} no array é {1} (Array iniciando da pos 0)", n, pos));
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        private static int BinarySearch(int[] arr, int n, int startPos, int endPos)
        {
            int midPos = (startPos + endPos) / 2;
            if (startPos > endPos)
            {
                throw new Exception("O número não foi encontrado no array");
            }
            if(arr[midPos] == n)
            {
                return midPos;
            }
            if (arr[midPos] > n)
            {
                return BinarySearch(arr, n, startPos, midPos - 1);
            }
            return BinarySearch(arr, n, midPos+1, endPos);
        }

        private static int getSearchN()
        {
            Console.WriteLine("Digite o número que deseja pesquisar:");
            return int.Parse(Console.ReadLine());
        }

        private static int[] getArray()
        {
            Console.WriteLine("Informe o size do seu array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(string.Format("Informe o item do array ({0})", i + 1));
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }
    }
}
