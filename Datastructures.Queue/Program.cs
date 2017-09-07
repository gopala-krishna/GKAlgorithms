using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures.Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //QueueUsingArray queue = new QueueUsingArray(1000);

            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //queue.Enqueue(40);

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Front());
            //Console.WriteLine(queue.Rear());

            //QueueUsingLinkedList queue = new QueueUsingLinkedList();

            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //queue.Enqueue(40);

            //Console.WriteLine(queue.Dequeue().key);
            //Console.WriteLine(queue.front.key);
            //Console.WriteLine(queue.rear.key);

            //QueueUsingStack queue = new QueueUsingStack();

            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);
            //queue.Enqueue(40);

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Front());
            //Console.WriteLine(queue.Rear());

            QueueUsingCSharpStack queue = new QueueUsingCSharpStack();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Front());
            Console.WriteLine(queue.Rear());


            Console.Read();

        }
    }
}
