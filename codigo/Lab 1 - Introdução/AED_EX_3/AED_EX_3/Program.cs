using System;
using System.Collections;

namespace AED_EX_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            Console.WriteLine("Preenchendo array 1: ");
            int[] vet1 = ReadArray();

            Console.Clear();
            Console.WriteLine("Preenchendo array 2: ");
            int[] vet2 = ReadArray();
            
            PopulateVet1Items(table, vet1);
            PopulateCommonItems(table, vet2);
            PopulateDiffItems(table, vet2);

            Console.ReadKey();
        }

        static int[] ReadArray()
        {
            int[] vet = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write(String.Format("Informe a {0}º posição do array: ", i+1));
                vet[i] = int.Parse(Console.ReadLine());
            }
            return vet;
        }

        private static void PopulateCommonItems(Hashtable table, int[] vet2)
        {
            Console.WriteLine("Itens em comum:");
            for (int i = 0; i < vet2.Length; i++)
            {
                if (table.ContainsKey(vet2[i]))
                {
                    Console.WriteLine(vet2[i]);
                }
            }
        }

        private static void PopulateDiffItems(Hashtable table, int[] vet2)
        {
            Console.WriteLine("Itens diferentes:");
            for (int i = 0; i < vet2.Length; i++)
            {
                if (!table.ContainsKey(vet2[i]))
                {
                    Console.WriteLine(vet2[i]);
                }
            }
        }

        private static void PopulateVet1Items(Hashtable table, int[] vet1)
        {
            for (int i = 0; i < vet1.Length; i++)
            {
                if (!table.ContainsKey(vet1[i]))
                {
                    table.Add(vet1[i], i);
                }
            }
        }
    }
}
