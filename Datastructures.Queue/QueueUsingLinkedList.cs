using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures.Queue
{
    // A linked list (LL) node to store a queue entry
    public class QNode
    {
        public int key;
        public QNode next;

        // constructor to create a new linked list node
        public QNode(int key)
        {
            this.key = key;
            this.next = null;
        }
    }

   public class QueueUsingLinkedList
    {
        public QNode front, rear;

        public QueueUsingLinkedList()
        {
            this.front = this.rear = null;
        }

        // Method to add an key to the queue.  
        public void Enqueue(int key)
        {

            // Create a new LL node
            QNode temp = new QNode(key);

            // If queue is empty, then new node is front and rear both
            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }

            // Add the new node at the end of queue and change rear
            this.rear.next = temp;
            this.rear = temp;
        }

        // Method to remove an key from queue.  
       public  QNode Dequeue()
        {
            // If queue is empty, return NULL.
            if (this.front == null)
                return null;

            // Store previous front and move front one node ahead
            QNode temp = this.front;
            this.front = this.front.next;

            // If front becomes NULL, then change rear also as NULL
            if (this.front == null)
                this.rear = null;
            return temp;
        }
    }
}
