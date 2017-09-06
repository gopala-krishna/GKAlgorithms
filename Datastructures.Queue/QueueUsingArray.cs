using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures.Queue
{
    public class QueueUsingArray
    {
        int front = 0; int rear = 0; int size = 0;
        int capacity;
        int[] array;

        public QueueUsingArray(int capacity)
        {
            this.capacity = capacity;
            front = this.size;
            rear = capacity - 1;
            array = new int[this.capacity];

        }

        // Queue is full when size becomes equal to the capacity 
        public bool IsFull(QueueUsingArray queue)
        {
            return (queue.size == queue.capacity);
        }

        // Queue is empty when size is 0
        public bool IsEmpty(QueueUsingArray queue)
        {
            return (queue.size == 0);
        }

        // Method to add an item to the queue. It changes rear and size
       public void Enqueue(int item)
        {
            if (IsFull(this))
                return;
            this.rear = (this.rear + 1) % this.capacity;
            this.array[this.rear] = item;
            this.size = this.size + 1;
            Console.WriteLine(item + "Enqueued to queue");
        }

        // Method to remove an item from queue. It changes front and size
       public  int Dequeue()
        {
            if (IsEmpty(this))
                return int.MinValue;

            int item = this.array[this.front];
            this.front = (this.front + 1) % this.capacity;
            this.size = this.size - 1;
            return item;
        }

        // Method to get front of queue
        public int Front()
        {
            if (IsEmpty(this))
                return int.MinValue;

            return this.array[this.front];
        }

        // Method to get rear of queue
       public int Rear()
        {
            if (IsEmpty(this))
                return int.MinValue;
            return this.array[this.rear];
        }

    }
}
