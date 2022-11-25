using System;

namespace Calculadora_Polonesa
{
    public class MyQueue<T>
    {
        private MyQueue<T> First;
        private MyQueue<T> Last;
        private MyQueue<T> Next;

        private T Obj;
        public void Push(T obj)
        {
            MyQueue<T> item = new MyQueue<T>();
            item.Obj = obj;

            if (Last == null)
            {
                First = item;
                Last = item;
            }
            else
            {
                Last.Next = item;
                Last = item;
            }

        }

        public bool IsEmpty()
        {
            return First == null;
        }

        public T Pull()
        {
            if (IsEmpty())
            {
                throw new Exception("No more items on the queue");
            }
            T obj = First.Obj;
            
            if(First.Next != null)
            {
                First = First.Next;
            } 
            else
            {
                First = null;
            }
            return obj;
        }

        public T Peek()
        {
            return First.Obj;
        }

        public MyQueue<T> Clone()
        {
            MyQueue<T> clone = new MyQueue<T>();
            MyQueue<T> first = First;
            while (first.Next != null)
            {
                clone.Push(first.Obj);
                first = first.Next;
            }
            clone.Push(first.Obj);
            return clone;
        }

        public void Print()
        {
            MyQueue<T> clone = Clone();
            while (!clone.IsEmpty())
            {
                Console.Write(clone.Pull() + " ");
            }
        }
    }
}
