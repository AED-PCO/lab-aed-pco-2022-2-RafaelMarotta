using System;
using System.Collections.Generic;

namespace PILHA_PARA_PILHA
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack1 = new Stack<string>();
            Stack<string> stack2 = new Stack<string>();
            
            stack1.Push("Exemplo 1");
            stack1.Push("Exemplo 2");
            stack1.Push("Exemplo 3");
            stack1.Push("Exemplo 4");

            while(stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }

            while(stack2.Count > 0)
            {
                Console.WriteLine(stack2.Pop());
            }

            Console.ReadKey();
        }
    }
}
