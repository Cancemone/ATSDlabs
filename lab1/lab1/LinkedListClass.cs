using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class LinkedListClass <T> where T : IComparable
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;

        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool Empty
        {
            get
            {
                return count == 0;
            }
        }
        public LinkedListNode<T> First
        {
            get
            {
                return head;
            }
        }
    }
}
