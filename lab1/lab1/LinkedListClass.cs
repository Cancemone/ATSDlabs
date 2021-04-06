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
        public void RemoveAfter(LinkedListNode<T> node)
        {
            LinkedListNode<T> removedNode = node.Next;
            node.Next = removedNode.Next;
            removedNode.Next = null;
            if (removedNode == tail)
            {
                tail = node;
            }
            count--;
        }
        public void Remove(LinkedListNode<T> node)
        {
            if (node.Next != null)
            {
                node.Value = node.Next.Value;
                RemoveAfter(node);
            }
            else
            {
                //delete tail
                if (head == tail)
                {
                    head = tail = null;
                    count--;
                }
                else
                {
                    RemoveAfter(FindPrevNode(node));
                }
            }
        }
        public LinkedListNode<T> FindPrevNode(LinkedListNode<T> node)
        {
            LinkedListNode<T> prevNode = null;
            LinkedListNode<T> currentNode = head;

            while (currentNode != null)
            {
                prevNode = currentNode;
                currentNode = currentNode.Next;
            }

            return prevNode;
        }
        public void ListEqual(LinkedList<T> L2)
        {
            LinkedListNode<T> current1 = head;
            LinkedListNode<T> current2 = L2.head;
            if (count.CompareTo(L2.count) == 0)
            {

                while (current1 != null)
                {
                    if (current1.Value.CompareTo(current2.Value) != 0)
                    {
                        Console.WriteLine("Lists are diffrent");
                        break;
                    }
                    current1 = current1.Next;
                    current2 = current2.Next;
                }
                PrintList();
                L2.PrintList();
            }
        }
        public void PrintList()
        {
            LinkedListNode<T> current = head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        public void Add(T value)
        {
            if (head == null)
            {
                head = tail = new LinkedListNode<T>(value, null);
                count++;
            }
            else
            {
                AddAfter(tail, value);
                tail = tail.Next;
            }
        }
    }
}
