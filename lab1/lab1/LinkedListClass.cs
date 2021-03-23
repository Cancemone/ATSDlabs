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
    }
}
