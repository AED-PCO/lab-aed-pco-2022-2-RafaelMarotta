using System;

namespace INSERTION_SORT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = getArray();
            int[] sortedArr = InsertionSort(arr);
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

        private static int[] InsertionSort(int[] arr)
        {
            for (int refPos = 1; refPos < arr.Length; refPos++) //Run over all elements on array
            {
                int value = arr[refPos]; //Get refVal
                int currPos = refPos-1; 

                while (currPos >= 0 && arr[currPos] > value) //until pos doesn´t exist or value is on the right place
                {
                    arr[currPos + 1] = arr[currPos]; //Shift arr to right
                    currPos--; //Back one pos to validate
                }
                arr[currPos + 1] = value; //Set the refVal on the right pos
            }
            return arr; //Return arr
        }
    }
}
