using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REMOVE_VOGAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texto:");
            string txt = Console.ReadLine();
            Console.WriteLine("Resultado:");
            Console.WriteLine(RemoveWovels(txt.ToCharArray()));
            Console.ReadKey();
        }

        static char[] Wovels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U', 'á', 'é', 'í', 'ó', 'ú', 'ã', 'õ', 'Ã', 'Õ', 'â', 'ê', 'î', 'ô', 'û', 'Â', 'Ê', 'Î', 'Ô', 'Û'};

        static string RemoveWovels(char[] txt, int aux = -1, string output = "")
        {
            aux++;
            if (aux == txt.Length)
            {
                return output;
            }
            if (!Wovels.ToList().Contains(txt[aux]))
            {
                output += txt[aux];
            }
            return RemoveWovels(txt, aux, output);
        }
    }
}
