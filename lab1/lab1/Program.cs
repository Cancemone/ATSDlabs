using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
  
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListClass<int> numberList = new LinkedListClass<int>();
            LinkedListClass<int> numberList2 = new LinkedListClass<int>();
            LinkedListClass<int> numberList3 = new LinkedListClass<int>();
            numberList.Add(1234);
            numberList.Add(5);
            numberList.Add(6);
            numberList.Add(7);
            numberList2.Add(1);
            numberList2.Add(2);
            numberList2.Add(3);
            numberList2.Add(4);
            numberList2.Add(5);
            numberList2.Add(6);
            numberList2.Add(7);
            numberList3.Add(1);
            numberList3.Add(3);
            numberList3.Add(5);
            numberList3.Add(7);
            numberList3.Add(9);
            numberList3.Add(12);
            numberList3.Add(15);
            numberList.TheBiggest(numberList2, numberList3);
            Console.ReadKey();
        }
    }
}
