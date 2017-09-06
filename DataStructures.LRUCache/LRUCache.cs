using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// O(1) lookup time ~ O(1) insertion time ~ O(1) deletion time
/// </summary>
namespace DataStructures.LRUCache
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="D"></typeparam>
    /// <typeparam name="K"></typeparam>
    public class Node<D, K>
    {
        public D Data { get; private set; }
        public K Key { get; private set; }
        public Node<D, K> Previous { get; set; }
        public Node<D, K> Next { get; set; }

        public Node(D data, K key)
        {
            Data = data;
            Key = key;
        }
    }
    public class LRUCache<K, V>
    {
        private readonly int maxCapacity = 0;
        private readonly Dictionary<K, Node<V, K>> lruCache;
        private Node<V, K> head = null;
        private Node<V, K> tail = null;

        public LRUCache(int argMaxCapacity)
        {
            maxCapacity = argMaxCapacity;
            lruCache = new Dictionary<K, Node<V, K>>();
        }

        public void Insert(K key, V value)
        {
            if (lruCache.ContainsKey(key))
            {
                MakeMostRecentlyUsed(lruCache[key]);
            }

            if (lruCache.Count >= maxCapacity)
            {
                RemoveLeastRecentlyUsed();
            }

            Node<V, K> insertedNode = new Node<V, K>(value, key);

            if (head == null)
            {
                head = insertedNode;
                tail = head;
            }
            else
            {
                MakeMostRecentlyUsed(insertedNode);
            }

            lruCache.Add(key, insertedNode);
        }

        private void MakeMostRecentlyUsed(Node<V, K> foundItem)
        {
            // Newly inserted item bring to the top
            if (foundItem.Next == null && foundItem.Previous == null)
            {
                foundItem.Next = head;
                head.Previous = foundItem;
                if (head.Next == null) tail = head;
                head = foundItem;
            }
            // If it is the tail than bring it to the top
            else if (foundItem.Next == null && foundItem.Previous != null)
            {
                foundItem.Previous.Next = null;
                tail = foundItem.Previous;
                foundItem.Next = head;
                head.Previous = foundItem;
                head = foundItem;
            }
            // If it is an element in between than bring it to the top
            else if (foundItem.Next != null && foundItem.Previous != null)
            {
                foundItem.Previous.Next = foundItem.Next;
                foundItem.Next.Previous = foundItem.Previous;
                foundItem.Next = head;
                head.Previous = foundItem;
                head = foundItem;
            }
            // Last case would be to check if it is a head but if it is than there is no need to bring it to the top
        }

        private void RemoveLeastRecentlyUsed()
        {
            lruCache.Remove(tail.Key);
            tail.Previous.Next = null;
            tail = tail.Previous;
        }

        public Node<V, K> GetItem(K key)
        {
            if (!lruCache.ContainsKey(key)) return null;

            MakeMostRecentlyUsed(lruCache[key]);

            return lruCache[key];
        }

        public int Size()
        {
            return lruCache.Count();
        }

        public string CacheFeed()
        {
            var headReference = head;

            List<string> items = new List<string>();

            while (headReference != null)
            {
                items.Add(String.Format("[V: {0}]", headReference.Data));
                headReference = headReference.Next;
            }
            return String.Join(",", items);
        }

       
    }
}
