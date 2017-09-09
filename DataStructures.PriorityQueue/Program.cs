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
            pq.Add(3,100, "Gpala");
            pq.Add(8,108, "Gopla");
            pq.Add(4,104, "Gpala");
            pq.Add(9,109, "Goala");

            //pq.Print();

            Console.Read();
        }
    }
}
