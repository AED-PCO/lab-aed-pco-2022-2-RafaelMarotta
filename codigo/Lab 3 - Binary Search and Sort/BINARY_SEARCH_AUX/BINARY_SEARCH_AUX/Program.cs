using System;
using System.Linq;

namespace BINARY_SEARCH_AUX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = getArray();
            int n = getSearchN();
            try
            {
                int pos = BinarySearch(arr, n, 0);
                Console.WriteLine(string.Format("A posição do número {0} no array é {1} (Array iniciando da pos 0)", n, pos));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        private static int BinarySearch(int[] arr, int n, int aux)
        {
            int mid = (arr.Length - 1) / 2;
            aux += mid+1;

            if (arr.Length <= 0)
            {
                throw new Exception("O número não foi encontrado no array");
            }

            if (arr[mid] == n)
            {
                return aux - 1;
            }

            if (arr[mid] > n)
            {
                arr = arr.Take(mid).ToArray();
                return BinarySearch(arr, n, aux - (mid+1));
            }

            arr = arr.Skip(mid + 1).ToArray();
            return BinarySearch(arr, n, aux);
        
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