using System;
using System.Linq;

namespace BINARY_SORT_AUX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GetArray();
            int[] sortedArr = BinarySort(arr);
            Console.WriteLine("O array ordenado é: " + string.Join(",", sortedArr));
            Console.ReadKey();
        }
        private static int BinarySearch(int[] arr, int n, int aux)
        {
            int mid = (arr.Length - 1) / 2;
            aux += mid + 1;

            if (arr.Length <= 0)
            {
                return aux - 1;
            }

            if (arr[mid] == n)
            {
                return aux - 1;
            }

            if (arr[mid] > n)
            {
                arr = arr.Take(mid).ToArray();
                return BinarySearch(arr, n, aux - (mid + 1));
            }

            arr = arr.Skip(mid + 1).ToArray();
            return BinarySearch(arr, n, aux);

        }

        private static int[] BinarySort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int pos = BinarySearch(arr.Take(i).ToArray(), arr[i], 0);
                arr = ShiftArray(arr, i, pos);
            }
            return arr;
        }

        private static int[] GetArray()
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


        static int[] ShiftArray(int[] arr, int oldPos, int newPos)
        {
            int val = arr[oldPos];
            if (arr.Length > 1)
            {
                for (int i = oldPos; i >= newPos; i--)
                {
                    if (i != newPos)
                    {
                        arr[i] = arr[i - 1];
                    }
                }
            }
            arr[newPos] = val;
            return arr;
        }

    }
}
