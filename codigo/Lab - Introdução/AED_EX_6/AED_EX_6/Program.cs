using System;

namespace AED_EX_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("\nInforme o número y: ");
            int y = int.Parse(Console.ReadLine());
            int pow = Pow(x, ref y);
            Console.Clear();
            string message = string.Format("O resultado de {0} elevado a {1} é: {2}", x, y, pow);
            Console.WriteLine(message);
            Console.ReadKey();
        }

        static int Pow(int x, ref int y)
        {
            int pow = 1;
            for(int i = 0; i < y; i++)
            {
                pow = pow * x;
            }
            return pow;
        }
    }
}
