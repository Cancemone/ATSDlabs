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
        private void Resize(ref T[] array, int leng)
        {
            T[] array2 = new T[leng];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            array = array2;
        }
        public void PrintList()
        {
            for (int i = 0; i <= last; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        private void Heapify(T[] array, int pos, int size)
        {
            T temp;
            while (2 * pos + 1 < size)
            {
                int t = 2 * pos + 1;
                if (2 * pos + 2 < size && array[2 * pos + 2].CompareTo(array[t]) >= 0)
                {
                    t = 2 * pos + 2;
                }
                if (array[pos].CompareTo(array[t]) < 0)
                {
                    temp = array[pos];
                    array[pos] = array[t];
                    array[t] = temp;
                    pos = t;
                }
                else break;
            }
        }
    }
}
