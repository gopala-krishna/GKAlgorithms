using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.PriorityQueue
{
    class PriorityQueue
    {
            Dictionary<int, KeyValuePair<int, string>> pq = new Dictionary<int, KeyValuePair<int, string>>();
            List<KeyValuePair<int, KeyValuePair<int, string>>> orderedPQList;


            public void Enqueue(int priority, int key, string value)
            {
                pq.Add(priority, new KeyValuePair<int, string>(key, value));
                var orderedPQ = pq.OrderBy(i => i.Key);
                orderedPQList = orderedPQ.ToList();
            }

            public void Dequeue()
            {
                orderedPQList.RemoveAt(0);
            }

        public void PrintBefore()
            {
                foreach (var item in pq)
                {
                    Console.WriteLine("Key :" + item.Key + "  " + "Value :" + item.Value);
                }
            }
        public void PrintAfter()
        {
            foreach (var item in orderedPQList)
            {
                Console.WriteLine("Key :" + item.Key + "  " + "Value :" + item.Value);
            }
        }
    }

    
}
