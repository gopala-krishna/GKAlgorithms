using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    /// <summary>
    /// This hashing method is also called "Seperate Chaining"
    /// In separate chaining, each element of the hash table is a linked list. 
    /// To store an element in the hash table you must insert it into a specific
    /// linked list. If there is any collision (i.e. two different elements have same hash value) 
    /// then store both the elements in the same linked list.
    /// </summary>
    public class OpenHashingHashTable
    {
        static int tableSize = 128;
        public class HashNode
        {
            int key;
            string data;
            HashNode next;
            //Constructor
            public HashNode(int key, string data)
            {
                this.key = key;
                this.data = data;
                next = null;
            }

            public int GetKey()
            {
                return key;
            }

            public void SetKey(int key)
            {
                this.key = key;
            }

            public string GetData()
            {
                return data;
            }

            public void SetData(string data)
            {
                this.data = data;
            }

            public HashNode GetNextNode()
            {
                return this.next;
            }

            public void SetNextNode(HashNode node)
            {
                this.next = node;
            }
        }

        HashNode[] table = new HashNode[tableSize];

        public void InsertData(int key, string data)
        {
            HashNode hashNode = new HashNode(key, data);

            int hash = key % tableSize;

            while (table[hash] != null && table[hash].GetKey() % tableSize != key % tableSize)
            {
                hash = (hash + 1) % tableSize;
            }

            if (table[hash] != null && hash == table[hash].GetKey() % tableSize)
            {
                hashNode.SetNextNode(table[hash].GetNextNode());
                table[hash].SetNextNode(hashNode);
                return;
            }
            else
            {
                table[hash] = hashNode;
            }
        }

        public string Search(int key)
        {
            int hash = key % tableSize;
            while (table[hash] != null && table[hash].GetKey() % tableSize != key % tableSize)
            {
                hash = (hash + 1) % tableSize;
            }
            HashNode current = table[hash];
            if (current != null)
            {
                while (current.GetKey() != key && current.GetNextNode() != null)
                {
                    current = current.GetNextNode();
                }
                if (current.GetKey() == key)
                {
                    return current.GetData();
                }
                else
                {
                    return "Nothing found!";
                }
            }
            return "Nothing Found";
        }

        public void Delete(int key)
        {
            int hash = key % tableSize;
            while (table[hash] != null && table[hash].GetKey() % tableSize != key % tableSize)
            {
                hash = (hash + 1) % tableSize;
            }

            HashNode current = table[hash];
            bool isRemoved = false;
            while (current != null)
            {
                if (current.GetKey() == key)
                {
                    table[hash] = current.GetNextNode();
                    Console.WriteLine("Entry removed successfully!");
                    isRemoved = true;
                    break;
                }

                if (current.GetNextNode() != null)
                {
                    if (current.GetNextNode().GetKey() == key)
                    {
                        HashNode newNext = current.GetNextNode().GetNextNode();
                        current.SetNextNode(newNext);
                        Console.WriteLine("Entry removed successfully!");
                        isRemoved = true;
                        break;
                    }
                    else
                    {
                        current = current.GetNextNode();
                    }
                }

            }
            if (!isRemoved)
            {
                Console.WriteLine("Nothing found to delete!");
                return;
            }
        }

        ///// <summary>
        ///// Check whether it is the right approach for chaining
        ///// </summary>
        //public void HashTableChaining()
        //{
        //    Hashtable ht = new Hashtable();

        //    // Insert the elements
        //    List<string> chain1 = new List<string>();
        //    chain1.Add("Gopala");
        //    chain1.Add("Krishna");

        //    List<string> chain2 = new List<string>();
        //    chain2.Add("Rao");
        //    chain2.Add("N");

        //    ht.Add(1, chain1);
        //    ht.Add(2, chain2);

        //    //Search for the element
        //    Console.WriteLine(((List<string>)ht[2]).Find(i=>i.Contains("Rao")));

    }
}
