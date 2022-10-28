using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILA_ESTATICA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho da sua fila:");
            int size = int.Parse(Console.ReadLine());
            FilaEstatica<string> queue = new FilaEstatica<string>(size);
            while(!queue.IsFull()) 
            {
                queue.Add(Console.ReadLine());    
            }

            Console.WriteLine("Dequeuing:");
            while(!queue.IsEmpty())
            {
                Console.WriteLine(queue.Pull());
            }

            queue.Add("Teste1");
            queue.Add("Teste2");

            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.Pull());
            }

            Console.ReadKey();
        }
    }
}
