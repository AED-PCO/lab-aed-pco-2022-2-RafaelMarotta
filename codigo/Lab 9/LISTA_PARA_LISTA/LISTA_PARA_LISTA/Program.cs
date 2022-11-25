using System;
using System.Collections.Generic;

namespace LISTA_PARA_LISTA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();

            list1.Add("Exemplo 1");
            list1.Add("Exemplo 2");
            list1.Add("Exemplo 3");
            list1.Add("Exemplo 4");

            string[] list2 = new string[list1.Count*2];

            for (int i = 0; i < list1.Count; i++)
            {
                list2[i] = list1[i];
                list2[list1.Count - 1 - i] = list1[i];
            }

            new List<>
        }
    }
}
