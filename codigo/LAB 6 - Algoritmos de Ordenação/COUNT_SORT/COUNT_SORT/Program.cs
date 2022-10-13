using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COUNT_SORT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = getArray();
            int[] sortedArr = CountSort(arr);
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
        private static int[] CountSort(int[] arr)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if(counter.ContainsKey(arr[i]))
                {
                    counter[arr[i]]++;
                } 
                else
                {
                    counter.Add(arr[i], 1);
                }
            }
            int aux = 0;
            foreach(int key in counter.Keys.OrderBy(key => key))
            {
                for(int i = 0; i < counter[key]; i++)
                { 
                    arr[aux] = key;
                    aux++;
                }
            }
            return arr;
        }

    }
}
