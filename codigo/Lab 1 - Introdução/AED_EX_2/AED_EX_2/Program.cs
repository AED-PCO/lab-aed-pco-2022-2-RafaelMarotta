using System;

namespace AED_EX_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(string.Format(IsPrimeNumber(n) ? 
                "O número {0} é um número primo" : 
                "O número {0} não é um número primo",
                n
            ));

            PrintPerfectNumbers();
            Console.ReadKey();
        }

        static void PrintPerfectNumbers()
        {
            Console.WriteLine("\n### Números Perfeitos de 1 a 1000 ###");
            for(int i = 1; i <= 1000; i++)
            {
                if (IsPerfectNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPerfectNumber(int n)
        {
            int sumOfDividers = 0;
            for(int i = n-1; i > 0; i--)
            {
                if(n % i == 0)
                {
                    sumOfDividers += i;
                }
            }
            return sumOfDividers == n;
        }

         static bool IsPrimeNumber(int n)
        {
            if (n == 1)
            {
                return false;
            }
            if (n < 3)
            {
                return true;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
