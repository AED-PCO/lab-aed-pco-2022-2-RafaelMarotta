using System;
using System.Linq;

namespace CONTA_LETRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o texto:");
            string txt = Console.ReadLine();
            Console.WriteLine("Informe a letra:");
            char letter = Console.ReadLine().ToCharArray()[0];
            int count = CountLetter(txt.ToCharArray(), letter);
            Console.WriteLine(string.Format("Quantidade de evidências da letra {0}: {1}", letter, count));
            Console.ReadKey();
        }

        static int CountLetter(char[] txt, char letter)
        {
            if (txt.Length == 1)
            {
                return 0;
            }
            txt = txt.Skip(1).Take(txt.Length-1).ToArray();
            return CountLetter(txt, letter) + (txt[0] == letter ? 1 : 0);
        }
    }
}
