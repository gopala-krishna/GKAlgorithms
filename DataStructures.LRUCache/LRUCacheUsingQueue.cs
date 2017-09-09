using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LRUCache
{
    class LRUCacheUsingQueue<T>
    {
        int capacity = 10;
        Queue<T> queue = new Queue<T>(10);

        public void Add(T item)
        {
            queue.Dequeue();
            queue.Enqueue(item);
        }

        public void Remove(T item)
        {
            queue.Dequeue();
        }

       





    }
}
