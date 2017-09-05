using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace DataStructures.HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //AnagramsForWordInDict ana = new AnagramsForWordInDict();
            //string[] arr = new string[] { "bca", "cde", "cac", "cab", "ccc" };
            //ana.AnagramsForWordInDict1("abc", arr);

            //HashTableBasics();
            HashTableChaining();
            Console.Read();
        }

        /// <summary>
        /// Hashtable is basically a data structure to retain values of key-value pair.
        /// It does not allow null for key.It will throw NullPointerException
        /// Hashtable does not maintain insertion order. The order is defined by the Hash function.So only use this if you do not need data in order.
        /// It is synchronized.It is slow.Only one thread can access in one time.
        /// HashTable is thread safe.
        /// HashTable uses Enumerator to iterate through elements.
        /// </summary>
        public static void HashTableBasics()
        {
            Hashtable ht = new Hashtable();


            ht.Add(1, "Gopala");
            //ht.Add(1, "krishna");  // Can't add same key
            ht.Add(2, "Gopala"); // Can add same value
            ht.Add(4, "Rao");

            ht.Add(1.ToString(), "one");
            ht.Add(2.ToString(), "two");

            string value1 = (string)ht[2];
            string value2 = (string)ht["1"];

            // ht.Add(null, "test"); can't add null key
            ht.Add(5, null);
            var value5 = ht[5];

        }

        ///// <summary>
        ///// Check whether it is the right approach for chaining
        ///// </summary>
        //public static void HashTableChaining()
        //{
        //    Hashtable ht = new Hashtable();

        //    List<string> chain1 = new List<string>();
        //    chain1.Add("Gopala");
        //    chain1.Add("Krishna");

        //    List<string> chain2 = new List<string>();
        //    chain2.Add("Rao");
        //    chain2.Add("N");

        //    ht.Add(1, chain1);
        //    ht.Add(2, chain2);

        //    var value = (List<string>)ht[2];
        //}
    }   
}
