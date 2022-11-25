using System;
using System.Collections.Generic;

namespace FILA_PARA_FILA_REVERSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue1 = new Queue<string>();
            Stack<string> helper = new Stack<string>();
            Queue<string> queue2 = new Queue<string>();

            queue1.Enqueue("Exemplo 1");
            queue1.Enqueue("Exemplo 2");
            queue1.Enqueue("Exemplo 3");
            queue1.Enqueue("Exemplo 4");

            while(queue1.Count > 0)
            {
                helper.Push(queue1.Dequeue());
            }

            while(helper.Count > 0)
            {
                queue2.Enqueue(helper.Pop());
            }

            while(queue2.Count > 0)
            {
                Console.WriteLine(queue2.Dequeue());
            }

            Console.ReadKey();
        }
    }
}
