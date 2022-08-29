using System;

namespace FATORIAL_RECURSIVA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            int num = int.Parse(Console.ReadLine());
            int fatorial = CalcFatorial(num);
            string output = String.Format("O resultado da fatorial de {0} é: {1}", num, fatorial);
            Console.WriteLine(output);
            Console.ReadKey();
        }

        static int CalcFatorial(int num)
        {
            return CalcFatorial(num, num);
        }

        static int CalcFatorial(int num, int aux)
        {
            if (aux == 1)
            {
                return 1;
            }
            return num * CalcFatorial(num, aux-1);
        }
    }
}
