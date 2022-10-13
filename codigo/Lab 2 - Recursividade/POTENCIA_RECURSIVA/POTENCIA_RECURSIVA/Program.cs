using System;


namespace POTENCIA_RECURSIVA
{
    internal class Program
    {

        // n = num, x = exp
        // x = 0 return 1
        // x > 0 return (n*n) for x times
        // x < 0 return (n/n) for x times

        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o expoente: ");
            int exp = int.Parse(Console.ReadLine());
            double pow = Pow(n, exp);
            string output = String.Format("O número {0} elevado a {1} é igual a: {2}", n, exp, pow);
            Console.WriteLine(output);
            Console.ReadKey();
        }

        static double Pow(int n, int x)
        {
            if (x == 0)
            {
                return 1;
            }
            if (x > 0)
            {
                return n * Pow(n, x - 1);
            }
            return Pow(n, x + 1) / n;
        }
    }
}
