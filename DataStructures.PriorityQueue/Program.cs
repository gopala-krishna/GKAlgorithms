using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue pq = new PriorityQueue();
            pq.Enqueue(3,100, "Gpala");
            pq.Enqueue(8,108, "Gopla");
            pq.Enqueue(4,104, "Gpala");
            pq.Enqueue(9, 109, "Goala");
            pq.Enqueue(12, 110, "Goalapp");

            pq.PrintBefore();
            Console.WriteLine();

            pq.PrintAfter();
            Console.WriteLine();


            pq.Dequeue();

            pq.PrintAfter();

            Console.Read();
        }
    }
}
