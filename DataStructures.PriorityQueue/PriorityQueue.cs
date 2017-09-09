using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.PriorityQueue
{
    class PriorityQueue
    {
            int CacheSize = 4;
            Dictionary<int, KeyValuePair<int, string>> pq = new Dictionary<int, KeyValuePair<int, string>>();
            List<KeyValuePair<int, KeyValuePair<int, string>>> orderedPQList;


            public void Enqueue(int priority, int key, string value)
            {
                pq.Add(priority, new KeyValuePair<int, string>(key, value));
                var orderedPQ = pq.OrderBy(i => i.Key);
                orderedPQList = orderedPQ.ToList();

            if (pq.Count() > CacheSize)
                {
                    pq.Remove(orderedPQList[0].Key);
                }
            }
        public int GetMaxPriority()
        {
            int maxVal = 0;
            foreach (var i in orderedPQList)
            {
                if (i.Key > maxVal)
                    maxVal = i.Key;
            }
            return maxVal;
        }

        public int Dequeue(int key)
        {
            foreach (var kv in pq)
            {
                if (kv.Value.Key.Equals(key))
                {
                    pq.Remove(kv.Key);

                    int newPriority = GetMaxPriority() + 1;

                    this.Enqueue(newPriority, kv.Value.Key, kv.Value.Value);
                    return kv.Value.Key;
                }
            }
            return default(int);
        }

        public void Print()
            {
                foreach (var item in orderedPQList)
                {
                    Console.WriteLine("Key :" + item.Key + "  " + "Value :" + item.Value);
                }
            }
     }

    
}
