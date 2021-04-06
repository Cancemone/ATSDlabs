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
        public LinkedList()
        {

        }
        public void AddAfter(LinkedListNode<T> node, T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value, node);
            node.Next = newNode;
            count++;
        }
        public void AddSort(T value)
        {
            if (head == null)
            {
                head = tail = new LinkedListNode<T>(value, null);
                count++;
            }
            else
            {
                LinkedListNode<T> current = head;
                while (current != null)
                {
                    if (value.CompareTo(current.Value) >= 0 && value.CompareTo(current.Next.Value) <= 0)
                    {
                        AddAfter(current, value);
                        break;
                    }
                    else if (value.CompareTo(head.Value) <= 0)
                    {
                        LinkedListNode<T> oldHead = head;
                        head = new LinkedListNode<T>(value, oldHead);
                        count++;
                        break;
                    }
                    else if (value.CompareTo(tail.Value) >= 0)
                    {
                        AddAfter(tail, value);
                        break;
                    }
                    current = current.Next;
                }
            }
        }
    }
}
