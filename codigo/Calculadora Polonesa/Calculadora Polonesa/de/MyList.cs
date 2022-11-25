namespace Calculadora_Polonesa
{
    public class MyList<T>
    {
        private MyList<T> First;
        private MyList<T> Last;
        private MyList<T> Previous;
        private MyList<T> Next;
        private T Obj;

        public void Add(T obj)
        {
            MyList<T> item = new MyList<T>();
            item.Obj = obj;
            if (First == null)
            {
                First = item;
                Last = item;
            } 
            else
            {
                Last.Next = item;
                item.Previous = Last;
                Last = item;
            }
        }

        public T Get(int pos)
        {
            return First.GetRecursive(pos);
        }

        private T GetRecursive(int pos)
        {
            if (pos == 0)
            {
                return Obj;
            }
            return Next.GetRecursive(pos - 1);
        }

        public void Remove(int pos)
        {
            First.RemoveRecursive(pos);
        }

        public void RemoveRecursive(int pos)
        {
            if (pos == 0)
            {
                Previous.Next = Next;
                Next.Previous = Previous;
            }
            else
            {
                Next.GetRecursive(pos - 1);
            }
        }

    }
}
