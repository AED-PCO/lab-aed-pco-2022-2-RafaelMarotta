using System;

namespace SELECTION_SORT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = getArray();
            int[] sortedArr = SelectionSort(arr);
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

        private static int[] SelectionSort(int[] arr)
        {
            for(int refPos = 0; refPos < arr.Length-1; refPos++)
            {
                int refVal = arr[refPos];
                int lowerPos = refPos + 1;

                for(int i = lowerPos+1; i < arr.Length; i++)
                {
                    if(arr[i] < arr[lowerPos])
                    {
                        lowerPos = i;    
                    }
                }
                if (arr[lowerPos] < arr[refPos])
                {
                    arr[refPos] = arr[lowerPos];
                    arr[lowerPos] = refVal;
                }
            }
            return arr;
        }
    }
}
