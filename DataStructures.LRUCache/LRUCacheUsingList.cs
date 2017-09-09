using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LRUCache
{
    class LRUCacheUsingList<Key,Value>
    {
        int CacheSize = 4;
        List<KeyValuePair<Key, Value>> dict = new List<KeyValuePair<Key, Value>>();
        public void Add(Key key, Value value)
        {
            dict.Add(new KeyValuePair<Key, Value>(key,value));
            if (dict.Count > CacheSize)
            {
                dict.Remove(dict[0]);
            }
        }
  
        public Key Get(Key key)
        {
            foreach (var kv in dict)
            {
                if(kv.Key.Equals(key))
                {
                    dict.Remove(kv);
                    dict.Add(kv);
                    return kv.Key;
                }
            }
            return default(Key);
        }

        public void Print()
        {
            foreach(var item in dict)
            {
                Console.WriteLine("Key :" + item.Key + "  " + "Value :" + item.Value);
            }
        }
    }
}
