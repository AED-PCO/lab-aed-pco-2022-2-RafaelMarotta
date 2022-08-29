using System;
using System.Linq;

namespace SOMA_VALOR_PAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ReadArray();
            int sumOfEvens = SumEvenNumbers(array);
            string output = string.Format("A soma dos elementos do array é: {0}", sumOfEvens);
            Console.WriteLine(output);
            Console.ReadKey();
        }

        static int[] ReadArray()
        {
            Console.WriteLine("Informe o número de elementos do array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("Informe um número:");
                int n = int.Parse(Console.ReadLine());
                array[i] = n;
            }
            return array;
        }

        static int SumEvenNumbers(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int n = nums[0];
            nums = nums.Skip(1).Take(nums.Length - 1).ToArray();
            if ((double) n % 2 == 0)
            {
                return n + SumEvenNumbers(nums);
            }
            return SumEvenNumbers(nums);
        }
    }
}
