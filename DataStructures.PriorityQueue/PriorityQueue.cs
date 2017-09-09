using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.PriorityQueue
{
    class PriorityQueue
    {
            int CacheSize = 2;
            Dictionary<int, KeyValuePair<int, string>> pq = new Dictionary<int, KeyValuePair<int, string>>();
             static List<KeyValuePair<int, KeyValuePair<int, string>>> orderedPQList;


            public void Add(int priority, int key, string value)
            {
                pq.Add(priority, new KeyValuePair<int, string>(key, value));
                var orderedPQ = pq.OrderBy(i => i.Key);
            
                if (pq.Count() > CacheSize)
                {
                    orderedPQList = orderedPQ.ToList();
                    pq.Remove(orderedPQList[0].Key);
                }
            }

            //public int Get(int key)
            //{
            //    foreach (var kv in orderedPQList)
            //    {
            //        if (kv.Key.Equals(key))
            //        {
            //            pq.Remove(key);
            //            //pq.Add(kv.Key);
            //            return kv.Key;
            //        }
            //    }
            //    return default(Key);
            //}

        public void Print()
            {
                foreach (var item in orderedPQList)
                {
                    Console.WriteLine("Key :" + item.Key + "  " + "Value :" + item.Value);
                }
            }
     }

    
}
