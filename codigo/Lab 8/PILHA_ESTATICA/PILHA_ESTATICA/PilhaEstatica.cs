using System;

namespace PILHA_ESTATICA
{
    public class PilhaEstatica<E>
    {
        private E[] array;
        private int aux = -1;
            
        public PilhaEstatica(int size)
        {
            array = new E[size];
        }
       
        public void Add(E obj)
        {
            if (IsFull())
            {
                throw new Exception("Stack is full");
            }
            aux++;
            array[aux] = obj;
        }

        public bool IsEmpty()
        {
            return aux <= -1;
        }

        public bool IsFull()
        {
            return !(aux < array.Length);
        }

        public E Pull()
        {
            if (IsEmpty())
            {
                throw new Exception("Item not found");
            }
            aux--;
            return array[aux+1];
        }
    }
}
