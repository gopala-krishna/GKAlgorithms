using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.LRUCache;

namespace Algorithms.Caching
{
    public class LazyCaching
    {
        LRUCacheUsingList<int, int> cache = new LRUCacheUsingList<int, int>();

        public void LazyCaching1()
        {
            cache.Add(5, 100);
            if(cache.Get(5) != 0)
            {
                Console.WriteLine("This is a cache hit. Returned value is :" + cache.Get(5));
            }
            else
            {
                Console.WriteLine("This is a cache miss. Get value from DB and add it to cache");
            }
        }



       
    }
}
