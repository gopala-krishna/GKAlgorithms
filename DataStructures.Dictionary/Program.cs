﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;

namespace DataStructures.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryBasics();
            Console.Read();
        }

        /// <summary>
        /// Dictionary is the Generic version of hash table
        /// </summary>

        public static void DictionaryBasics()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "Gopala");
            //dict.Add(1, "krishna");  same key can't be added
            dict.Add(2, "Gopala"); // same value can be added
            dict.Add(4, "Rao");

            foreach (var i in dict)
            {
                Console.WriteLine(i.Key.ToString() + "," + i.Value.ToString());
            }

        }

    }
}
