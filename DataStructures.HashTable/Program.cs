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

            //OpenHashingHashTable oh = new OpenHashingHashTable();
            //oh.InsertData(1, "gopala");
            //oh.InsertData(2, "krishna");
            //oh.InsertData(3, "rao");

            //Console.WriteLine(oh.Search(2));
            //Console.WriteLine(oh.Search(3));

            //oh.Delete(2);

            //Console.WriteLine(oh.Search(2));
            //Console.WriteLine(oh.Search(3));

            //oh.Delete(3);

            //oh.InsertData(2, "Krishna Rao");
            //Console.WriteLine(oh.Search(2));
            //Console.WriteLine(oh.Search(3));

            ClosedHashingHashTable ch = new ClosedHashingHashTable();

            //ch.LinearInsert(1, "Gopala");
            //ch.LinearInsert(2, "Krishna");
            //ch.LinearInsert(3, "Rao");

            //ch.QuadraticInsert(1, "Gopala");
            //ch.QuadraticInsert(2, "Krishna");
            //ch.QuadraticInsert(3, "Rao");

            ch.DoubleHashInsert(1, "Gopala");
            ch.DoubleHashInsert(2, "Krishna");
            ch.DoubleHashInsert(3, "Rao");


            ch.Search(2);
            ch.Search(3);

            ch.Delete(2);

            ch.Search(2);
            ch.Search(3);

            ch.Delete(3);

            ch.LinearInsert(2, "Krishna Rao");
            ch.Search(2);
            ch.Search(3);


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

            var hash = "abcdefgh".GetHashCode();


        }


    }   
}
