using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.LRUCache;

namespace Algorithms.Caching
{
    class EagerCaching
    {
        LRUCacheUsingList<int, int> cache = new LRUCacheUsingList<int, int>();

        public void EagerCaching1()
        {
          Console.WriteLine("Update cache whenever database is updated");
        }
    }
}
