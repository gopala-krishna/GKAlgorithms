using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class StackUsingArray
    {
        static int MAX = 1000;
        public int top;
        int[] arr = new int[MAX]; // Maximum size of Stack

        public StackUsingArray()
        {
            top = -1;
        }

        public bool Push(int x)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                arr[++top] = x;
                return true;
            }
        }

        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                return arr[top--];
            }
        }

        public bool IsEmpty()
        {
            return (top < 0);
        }

        public int Peek()
        {
            return arr[top];
        }
    }
}
