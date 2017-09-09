using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LRUCache
{
    class Program
    {
        static void Main(string[] args)
        {
            LRUCacheUsingList<int, int> cache = new LRUCacheUsingList<int, int>();
            cache.Add(1, 10);
            cache.Add(4, 40);
            cache.Add(5, 50);
            cache.Add(85, 150);
            cache.Add(25, 250);

            cache.Print();
            Console.WriteLine();

            Console.WriteLine(cache.Get(5).ToString());
            Console.WriteLine(cache.Get(85).ToString());
            Console.WriteLine(cache.Get(25).ToString());
            Console.WriteLine();

            cache.Print();


            //int cacheSize = 10;

            //LRUCache1<int, int> lruCache = new LRUCache1<int, int>(cacheSize);

            //Console.WriteLine(lruCache.Size());

            //lruCache.Add(0, 10);
            //lruCache.Add(1, 20);
            //lruCache.Add(2, 30);
            //lruCache.Add(3, 40);
            //lruCache.Add(4, 50);

            //Console.WriteLine(lruCache.Size());
            //lruCache.Feed();

            //lruCache.Get(0);
            //lruCache.Get(1);
            //lruCache.Get(2);

            //Console.WriteLine(lruCache.Size());
            //lruCache.Feed();

            //lruCache.Add(5, 60);
            //lruCache.Add(6, 70);
            //lruCache.Add(7, 80);
            //lruCache.Add(8, 90);
            //lruCache.Add(9, 100);

            //Console.WriteLine(lruCache.Size());
            //lruCache.Feed();
            Console.Read();
        }
    }
}
