using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class LinkedList<T> where T : IComparable<T>
    {
        public Node<T> Head;
        public Node<T> Tail;
        public int Count;
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public LinkedList(T data)
        {
            var item = new Node<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        public void AddNode(T data)
        {
            var item = new Node<T>(data);
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                Head = item;
                Tail = item;
                Count = 1;
            }
            sort();
        }
        public void sort()
        {
            for (int j = 0; j < Count; j++)
            {
                var current = Head;

                for (int i = 0; i < Count - 1; i++)
                {
                    if (current.Next != null && current.Data.CompareTo(current.Next.Data) > 0)
                    {
                        var temp = current.Data;
                        current.setItem(current.Next.Data);
                        current.Next.setItem(temp);
                    }
                    current = current.Next;
                }
            }
        }
        public void clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public void PrintList()
        {
            var current = Head;
            var result = "";

            while (current != null)
            {
                result += current.Data;
                result += ", ";
                current = current.Next;
            }
            Console.WriteLine(result);
        }
    }
}
