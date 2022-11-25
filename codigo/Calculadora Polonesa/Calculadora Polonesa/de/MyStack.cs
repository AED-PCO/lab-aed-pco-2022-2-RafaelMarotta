using System;

namespace Calculadora_Polonesa
{
    public class MyStack<T>
    {
        private MyStack<T> Next;
        private MyStack<T> Last;
        private T Obj;

        public void Push(T obj)
        {
            MyStack<T> item = new MyStack<T>();
            item.Obj = obj;

           if (Last == null) 
            {
                Last = item;
            }            
           else
            {
                item.Next = Last;
                Last = item;
            }
        }

        public bool IsEmpty()
        {
            return Last == null;
        }

        public T Peek()
        {
            return Last.Obj;
        }

        public T Pull()
        {
            if (IsEmpty())
            {
                throw new Exception("No more items on the stack");
            }
            T obj = Last.Obj;
            Last = Last.Next;
            return obj;
        }

    }
}
