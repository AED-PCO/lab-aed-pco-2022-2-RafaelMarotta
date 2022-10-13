using System;

namespace BINARY_SORT_SEM_AUX
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

        private static int[] BinarySort(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int pos = BinarySearch(arr, arr[i], 0, i);
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

        private static int BinarySearch(int[] arr, int n, int startPos, int endPos)
        {
            int midPos = (startPos + endPos) / 2;
            if (startPos > endPos)
            {
                return arr[midPos] > n ? midPos : midPos+1;
            }
            if (arr[midPos] == n)
            {
                return midPos;
            }
            if (arr[midPos] > n)
            {
                return BinarySearch(arr, n, startPos, midPos - 1);
            }
            return BinarySearch(arr, n, midPos + 1, endPos);
        }

        static int[] ShiftArray(int[] arr, int oldPos, int newPos)
        {
            int val = arr[oldPos];
            if (arr.Length > 1)
            {
              for(int i = oldPos; i >= newPos; i--)
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
