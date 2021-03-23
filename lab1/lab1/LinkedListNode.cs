using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class LinkedListNode<T>
    {
        //значение в узле списка
        public T Value;
        //следующий узел
        public LinkedListNode<T> Next;
        //constructor
        public LinkedListNode(T value, LinkedListNode<T> next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
