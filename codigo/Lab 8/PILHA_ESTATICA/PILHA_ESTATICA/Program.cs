using System;

namespace PILHA_ESTATICA
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Informe o tamanho da sua pilha:");
            int size = int.Parse(Console.ReadLine());
            PilhaEstatica<int> stack = new PilhaEstatica<int>(size);
            for (int i = 0; i < size; i++)
            {
                stack.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Desempilhando fila:");

            while(!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pull());
            }

            Console.ReadKey();
        
        }
        
    }
}
