using System;

namespace LISTA_ESTATICA
{
    public class ListaEstatica<E>
    {
        private E[] array;
        private int aux = 0;

        public ListaEstatica(int size)
        {
            array = new E[size];
        }

        public void Add(E obj)
        {
            if (IsFull())
            {
                throw new Exception("The list is full");
            }
            array[aux] = obj;
            aux++;
        }

        public void Add(E obj, int pos)
        {
            if (IsFull())
            {
                throw new Exception("The list is full");
            }

            if (IsPosOverflow(pos))
            {
                throw new Exception("The position does not exists");
            }

            ShiftRight(pos);
            array[pos] = obj;
            aux++;
        }

        public E Pull(int pos)
        {
            if (IsEmpty())
            {
                throw new Exception("The list is Empty");
            }

            if (IsPosOverflow(pos))
            {
                throw new Exception("The position does not exists");                
            }

            E val = array[pos];
            ShiftLeft(pos);
            aux--;
            return val;
        }

        private bool IsPosOverflow(int pos)
        {
            return pos > array.Length - 1;
        }

        public void ShiftLeft(int pos)
        {
            for (int i = pos; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
        }

        public void ShiftRight(int pos)
        {
            for (int i = array.Length-1; i > pos; i--)
            {
                array[i] = array[i - 1];
            }
        }

        public bool IsEmpty()
        {
            return aux == 0;
        }

        public bool IsFull()
        {
            return aux > array.Length - 1;
        }

    }
}
