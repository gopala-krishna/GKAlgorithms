using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class Node
    {
       public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    public class StackUsingLinkedList
    {
        Node head;
       
        public bool IsEmpty()
        {
            if (head == null)
                return true;
            else
                return false;
        }
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            newNode.next = null;
            //If Linkedlist is empty
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node last = head;
                while (last.next != null)
                {
                    last = last.next;
                }
                last.next = newNode;
            }
        }

        public void Pop()
        {
            Node last = head;
            Node prev = null;
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            while (last.next != null)
            {
                prev = last;
                last = last.next;
            }
            prev.next = null;
        }
        public int Peek()
        {
            Node last = head;
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            while (last.next != null)
            {
                last = last.next;
            }
            return last.data;
        }
    }
}
