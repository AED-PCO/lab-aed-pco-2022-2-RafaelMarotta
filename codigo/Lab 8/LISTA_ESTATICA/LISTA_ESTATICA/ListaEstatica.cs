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

        public E Get(int pos)
        {
            if (IsEmpty())
            {
                throw new Exception("The list is Empty");
            }

            if (pos > array.Length - 1)
            {
                throw new Exception("The position does not exists");
            }

            E val = array[pos];
            Shift(pos);
            return val;
        }

        public void Shift(int pos)
        {
            for (int i = pos; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            aux--;
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
