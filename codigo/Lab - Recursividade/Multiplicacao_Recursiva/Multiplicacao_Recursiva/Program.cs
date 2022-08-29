using System;

namespace Multiplicacao_Recursiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe outro número:");
            int y = int.Parse(Console.ReadLine());
            string output = string.Format("O número {0} x {1} = {2}", x, y, Multiply(x, y));
            Console.WriteLine(output);
            Console.ReadKey();
        }

        static int Multiply(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n2;
            }
            return n1 + Multiply(n1, n2-1);
        }
    }
}
