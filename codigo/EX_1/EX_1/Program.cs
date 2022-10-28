using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_1
{
    internal class Program
    {

        static Dictionary<string, int> iguais = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            List<string> palavrasArq = GetPalavrasArq();
            List<string> palavrasCon = ReadAllLines();
            PopuplateIguaisMap(palavrasArq);
            int fileSize = palavrasArq.Count;
            foreach(string palavra in palavrasCon)
            {
                int ig = 0;
                int dif = 0;

                if(iguais.ContainsKey(palavra))
                {
                    ig = iguais[palavra];
                }
                dif = fileSize - ig;
                string output = string.Format("Palavra \"{0}\" Iguais: {1} Diferentes: {2}", palavra, ig, dif);
                Console.WriteLine(output);
            }
            Console.ReadKey();

        }

        private static List<String> GetPalavras(List<String> linhas)
        {
            List<string> palavras = new List<string>();
            linhas.ForEach(linha =>
            {
                linha.Split(' ').ToList().ForEach(palavra =>
                {
                    palavras.Add(palavra);
                });
            });
            palavras.Remove("");
            return palavras;
        }

        private static void PopuplateIguaisMap(List<string> palavrasArq)
        {
            foreach (string palavra in palavrasArq)
            {
                if (!iguais.ContainsKey(palavra))
                {
                    iguais.Add(palavra, 1);
                }
                else
                {
                    int count = iguais[palavra] + 1;
                    iguais[palavra] = count;
                }
            }
        }

        private static List<string> GetPalavrasArq() => GetPalavras(File.ReadAllLines("arq1.txt").ToList());

        private static List<string> ReadAllLines()
        {
            string line = "";

            List<string> lines = new List<string>();    
            while (line != "+")
            {
                lines.Add(line);
                line = Console.ReadLine();
            }
            return GetPalavras(lines);
        }


    }
}
