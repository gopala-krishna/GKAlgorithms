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
            //SinglyLinkedList sll = new SinglyLinkedList();
            //sll.InsertAtStart(11);
            //sll.InsertAtStart(12);
            //sll.Append(14);
            //sll.PrintList();
            //sll.DeleteNode(12);
            //sll.PrintList();

            DoublyLinkedList dll = new DoublyLinkedList();
            dll.InsertAtStart(11);
            dll.InsertAtStart(12);
            dll.Append(14);
            dll.PrintList(dll.head);
            dll.DeleteNode(dll.head,dll.head.next);
            dll.PrintList(dll.head);

            Console.Read();

        }
    }
}
