using System;

namespace LISTA_ESTATICA
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho da lista:");
            int size = int.Parse(Console.ReadLine());
            ListaEstatica<string> list = new ListaEstatica<string>(size);

            while (!list.IsFull())
            {
                list.Add(Console.ReadLine());
            }

            Console.WriteLine("List on desc:");

            //Get list elements on desc
            for (int i = size - 1; i >= 0; i--)
            {
                Console.WriteLine(list.Get(i));
            }

            Console.ReadKey();

        }
    }
}
