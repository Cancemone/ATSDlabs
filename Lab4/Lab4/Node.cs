using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Node<T>
    {
        public T Data;
        public Node<T> Next;
        public Node(T data)
        {
            Data = data;
        }
        public void setItem(T i)
        {
            Data = i;
        }
        public void setNext(Node<T> n)
        {
            Next = n;
        }
    }
}
