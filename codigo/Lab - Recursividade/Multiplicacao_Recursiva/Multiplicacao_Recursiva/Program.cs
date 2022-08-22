using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicacao_Recursiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(3,4).ToString());
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
