using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILA_ESTATICA
{
    public class FilaEstatica<E>
    {
        private E[] array;
        private int aux = 0;

        public FilaEstatica(int size)
        {
            array = new E[size];
        }

        public void Add(E obj)
        {
            if (IsFull())
            {
                throw new Exception("The queue is full");
            }
            array[aux] = obj;
            aux++;
        }

        public E Pull()
        {
            if(IsEmpty())
            {
                throw new Exception("The queue is Empty");
            }
            E val = array[0];
            ShiftArrayLeft();
            return val;
        }

        public bool IsEmpty()
        {
            return aux == 0;
        }

        public void ShiftArrayLeft()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            aux--;
        }

        public bool IsFull()
        {
            return aux > array.Length-1;
        }

    }
}
