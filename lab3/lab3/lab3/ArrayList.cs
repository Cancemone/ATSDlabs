using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class ArrayList<T> where T : IComparable
    {
        public T[] array;
        public int max;
        int last;
        public ArrayList(int m = 10)
        {
            max = m;
            array = new T[max];
            last = -1;
        }
        public bool IsFull()
        {
            return last >= array.Length - 1;
        }
        public bool IsEmpty()
        {
            return last == -1;
        }
        public int Size()
        {
            return array.Length;
        }
        public void AddItem(T item)
        {
            if (IsFull()) Resize(ref array, array.Length + 1);
            array[++last] = item;

        }
    }
}
