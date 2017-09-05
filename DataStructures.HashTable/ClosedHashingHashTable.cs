using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    /// <summary>
    /// This hashing method is also called "Linear Probing" or "Open Addressing"
    /// In open addressing, instead of in linked lists, all entry records are stored in the array itself. 
    /// When a new entry has to be inserted, the hash index of the hashed value is computed and 
    /// then the array is examined (starting with the hashed index). If the slot at the hashed index 
    /// is unoccupied, then the entry record is inserted in slot at the hashed index else it proceeds
    /// in some probe sequence until it finds an unoccupied slot.
    /// </summary>
    public class ClosedHashingHashTable
    {
        static int tableSize = 128;
        public class HashEntry
        {
            int key;
            string data;

            public HashEntry(int key, string data)
            {
                this.key = key;
                this.data = data;
            }
            public int GetKey()
            {
                return this.key;
            }
            public string GetData()
            {
                return this.data;
            }
        }

        HashEntry[] table = new HashEntry[tableSize];
        public bool CheckOpenSpace()
        {
            bool isOpen = false;

            for (int i = 0; i < tableSize; i++)
            {
                if (table[i] == null)
                {
                    isOpen = true;
                }
            }
            return isOpen;
        }
        public void LinearInsert(int key, string data)
        {
            int hash = key % tableSize;

            if (!CheckOpenSpace()) //if no open spaces available
            {
                Console.WriteLine("Table is at full capacity!");
                return;
            }

            while (table[hash] != null && table[hash].GetKey() != key%tableSize)
            {
                hash = (hash + 1) % tableSize;
            }
            table[hash] = new HashEntry(key, data);
        }

        public void QuadraticInsert(int key, string data)
        {
            int hash = key % tableSize; 

            if (!CheckOpenSpace()) //if no open spaces available
            {
                Console.WriteLine("Table is at full capacity!");
                return;
            }

            int i = 1;
            while (table[hash] != null && table[hash].GetKey() != key % tableSize)
            {
                hash = (hash + i*i) % tableSize;
                i++;
            }
            table[hash] = new HashEntry(key, data);
        }

        public void DoubleHashInsert(int key, string data)
        {
            int hash = key % tableSize;

            if (!CheckOpenSpace()) //if no open spaces available
            {
                Console.WriteLine("Table is at full capacity!");
                return;
            }

            int hash1 = key % tableSize; int hash2 = 5 - key % tableSize; // hash 2 must be non-zero, less than array size, ideally odd

            while (table[hash] != null && table[hash].GetKey() != key % tableSize)
            {
                hash = (hash + hash1 * hash2) % tableSize;
            }
            table[hash] = new HashEntry(key, data);
        }

        public void Search(int key)
        {
            int hash = key % tableSize;
            while (table[hash] != null && table[hash].GetKey() != key)
            {
                hash = (hash + 1) % tableSize;
            }
            if (table[hash] == null)
            {
                Console.WriteLine("Nothing found!");
            }
            else
            {
                Console.WriteLine(table[hash].GetData());
            }
        }

        public void Delete(int key)
        {
            int hash = key % tableSize;
            while (table[hash] != null && table[hash].GetKey() != key)
            {
                hash = (hash + 1) % tableSize;
            }
            if (table[hash] == null)
            {
                Console.WriteLine("Nothing found to Delete!");
            }
            else
            {
                table[hash] = null;
                Console.WriteLine("Deleted Successfully");
            }
        }
    }
}
