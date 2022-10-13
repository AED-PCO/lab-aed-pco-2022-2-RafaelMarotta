using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int counter = 0;
        static void Main(string[] args)
        {
            alg4(new int[] { 2, 3, 5, 4 });
            Console.WriteLine(counter);
            Console.ReadKey();
        }

        public static double[] alg4(int[] dados)
        {
            double[] vet = new double[dados.Length];
            for (int i = 0; i < dados.Length; i++)
            {
                double soma = 0.0;
                for (int j = 0; j <= i; j++)
                {
                    counter++;
                    soma += dados[j];
                }
                vet[i] = soma / (i + 1);
            }
            return vet;
        }

    }
}
