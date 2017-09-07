using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    class QueueUsingTwoCSharpStacks
    {
        public Stack<int> stack1 = new Stack<int>();
        public Stack<int> stack2 = new Stack<int>();

        //Function to enqueue an item to the queue
        public void Enqueue(int x)
        {
            stack1.Push(x);
        }
        /* Function to dequeue an item from queue */
        public int Dequeue()
        {
            int x = 0;
            /* If both stacks are empty then error */
            if (stack1.Count==0 && stack2.Count==0)
            {
                Console.WriteLine("Q is empty");
                return 0;
            }

            /* Move elements from stack1 to stack 2 only if
            stack2 is empty */
            if (stack2.Count==0)
            {
                while (stack1.Count !=0)
                {
                    x = stack1.Pop();
                    stack2.Push(x);
                }
            }
            x = stack2.Pop();
            return x;
        }

        public bool IsEmpty(QueueUsingArray queue)
        {
            return (stack2.Count==0);
        }

        // Method to get front of queue
        public int Front()
        {
            if (stack2.Count==0)
                return int.MinValue;
            return stack2.Pop();
        }

        // Method to get rear of queue
        public int Rear()
        {
            int x = 0;
            /* If both stacks are empty then error */
            if (stack1.Count == 0 && stack2.Count == 0)
            {
                Console.WriteLine("Q is empty");
                return 0;
            }

            /* Move elements from stack2 to stack 1 only if
            stack1 is empty */
            if (stack1.Count == 0)
            {
                while (stack2.Count != 0)
                {
                    x = stack2.Pop();
                    stack1.Push(x);
                }
            }
            x = stack1.Pop();
            return x;
        }
    }
}

