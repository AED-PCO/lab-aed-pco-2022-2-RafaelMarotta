using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED_EX_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();
            string message = string.Format("A fatorial de {0} é: {1}", num, GetFatorial(num));
            Console.WriteLine(message);
            Console.ReadKey();
        }

        static int GetFatorial(int num)
        {
            int fat = 1;
            for (int i = 1; i <= num; i++)
            {
                fat = fat * i;
            }
            return fat;
        }
    }
}
