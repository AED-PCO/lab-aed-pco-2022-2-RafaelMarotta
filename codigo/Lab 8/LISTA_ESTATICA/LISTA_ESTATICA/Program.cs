using System;

namespace LISTA_ESTATICA
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho da lista:");
            int size = int.Parse(Console.ReadLine());
            ListaEstatica<string> list = new ListaEstatica<string>(size+1);

            for(int i = 0; i < size;i++)
            {
                list.Add(Console.ReadLine());
            }

            list.Add("FORCED", 1);

            Console.WriteLine("List on desc:");

            for(int i = 0; i < size+1; i++)
            {
                Console.WriteLine(list.Pull(0));
            }

            Console.ReadKey();
        }
    }
}
