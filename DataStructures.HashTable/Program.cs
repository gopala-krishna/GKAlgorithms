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

            HashTableBasics();
            Console.Read();
        }

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
        }
    }
}
