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

            
            /* Three nodes have been allocated dynamically.
          We have refernces to these three blocks as first,  
          second and third
 
          llist.head        second              third
             |                |                  |
             |                |                  |
         +----+------+     +----+------+     +----+------+
         | 1  | null |     | 2  | null |     |  3 | null |
         +----+------+     +----+------+     +----+------+ */

            // Link first node with the second node

            /*  Now next of first Node refers to second.  So they
                both are linked.

             llist.head        second              third
                |                |                  |
                |                |                  |
            +----+------+     +----+------+     +----+------+
            | 1  |  o-------->| 2  | null |     |  3 | null |
            +----+------+     +----+------+     +----+------+ */

            // Link second node with the third node

            /*  Now next of second Node refers to third.  So all three
                nodes are linked.

             llist.head        second              third
                |                |                  |
                |                |                  |
            +----+------+     +----+------+     +----+------+
            | 1  |  o-------->| 2  |  o-------->|  3 | null |
            +----+------+     +----+------+     +----+------+ */

            //sll.head = new Node(3);
            //Node second = new Node(2);
            //sll.head.next = second;
            //Node third = new Node(1);
            //second.next = third;

            //sll.PrintList();

            //DoublyLinkedList dll = new DoublyLinkedList();
            //dll.InsertAtStart(11);
            //dll.InsertAtStart(12);
            //dll.Append(14);
            //dll.PrintList(dll.head);
            //dll.DeleteNode(dll.head,dll.head.next);
            //dll.PrintList(dll.head);




            Console.Read();

        }
    }
}
