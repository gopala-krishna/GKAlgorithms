using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Stack;

namespace DataStructures.Queue
{
    class QueueUsingOneStack
    {
        StackUsingArray  stack = new StackUsingArray();
      
        /* Function to enqueue an item to queue */
        public void Enqueue(int x)
        {
            stack.Push(x);
            Console.WriteLine(x + " is pushed into the stack");
        }

        /* Function to dequeue an item from queue */
        public int Dequeue()
        {
            int x, res = 0;
            /* If the stacks is empty then error */
            if (stack.IsEmpty())
            {
                Console.WriteLine("Q is Empty");
                return 0;
            }
            //Check if it is a last element of stack
            else if (stack.Count() ==1)
            {
                return stack.Pop();
            }
            else
            {
                /* pop an item from the stack */
                x = stack.Pop();

                /* store the last dequeued item */
                res = Dequeue();

                /* push everything back to stack */
                stack.Push(x);
                return res;
            }
        }

        public int Rear()
        {
            if (stack.IsEmpty())
                return int.MinValue;
            return stack.Pop();
        }

        public int Front()
        {
            return Dequeue();
        }


    }
    
}

