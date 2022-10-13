using System;

namespace BUBLE_SORT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = getArray();
            int[] sortedArr = BubleSortArr(arr);
            Console.WriteLine("O array ordenado é: " + string.Join(",", sortedArr));
            Console.ReadKey();
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

        static int[] BubleSortArr(int[] arr)
        {
            for(int i = arr.Length-1; i >= 0; i--)
            {
                for(int i1 = 0; i1 < (arr.Length - 1); i1++)
                {
                    if (arr[i1] > arr[i1+1])
                    {
                        int aux = arr[i1];
                        arr[i1] = arr[i1 + 1];
                        arr[i1 + 1] = aux;
                    }
                }
            }
            return arr;
        }
    }
}
