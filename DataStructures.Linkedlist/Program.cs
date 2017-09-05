using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            sll.Add("A");
            sll.Add("B");
            sll.Add("C");
            sll.Add("D");
            sll.ListNodes();
            var res =sll.Retrieve(2);
            Console.Read();

        }
    }
}
