using System;

namespace AED_EX_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1000; i < 9999; i++)
            {
                if(IsSumOfPowEqualsNum(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        static bool IsSumOfPowEqualsNum(double n)
        {
            double n1 = Math.Truncate(n / 100);
            double n2 = n % 100;
            return n == GetPowOfSum(n1, n2);
        }

        static double GetPowOfSum(double n1, double n2)
        {
            return Math.Pow(n1 + n2, 2);
        }
    }
}
