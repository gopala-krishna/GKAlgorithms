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
    public class OpenHashing
    {
        /// <summary>
        /// Check whether it is the right approach for chaining
        /// </summary>
        public void HashTableChaining()
        {
            Hashtable ht = new Hashtable();

            // Insert the elements
            List<string> chain1 = new List<string>();
            chain1.Add("Gopala");
            chain1.Add("Krishna");

            List<string> chain2 = new List<string>();
            chain2.Add("Rao");
            chain2.Add("N");

            ht.Add(1, chain1);
            ht.Add(2, chain2);

            //Search for the element
            Console.WriteLine(((List<string>)ht[2]).Find(i=>i.Contains("Rao")));
        }
    }
}
