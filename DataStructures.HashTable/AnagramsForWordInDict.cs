using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Collections;

namespace DataStructures.HashTable
{
    class AnagramsForWordInDict
    {
        public void AnagramsForWordInDict1(string word, string[] dict)
        {
           int  wordHash = ComputeHash(word);

            for(int i = 0; i<dict.Length;i++)
            {
                if(wordHash == ComputeHash(dict[i]))
                {
                    Console.WriteLine(i + "," + dict[i]);
                }

            }
        }

        /// <summary>
        /// a=2, b=3, c=5, d=7, e=11, f=13, g=17, h=19, i=23, j=29, 
        /// k=31, l=37, m=41, n=43, o=47, p=53, q=59, r=61, s=67, t=71, 
        ///u=73, v=79, w=83, x=89, y=97, z=101
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        private int ComputeHash(string word)
        {

            Hashtable ht = new Hashtable(); int hashVal = 1;

            ht.Add("a", 2); ht.Add("b", 3); ht.Add("c", 5); ht.Add("d", 7); ht.Add("e", 11);
            ht.Add("f", 13); ht.Add("g",17 ); ht.Add("h",19); ht.Add("i",23); ht.Add("j",29);
            ht.Add("k", 31); ht.Add("l", 37); ht.Add("m", 41); ht.Add("n", 43); ht.Add("o", 47);
            ht.Add("p", 53); ht.Add("q", 59); ht.Add("r", 61); ht.Add("s", 67); ht.Add("t", 71);
            ht.Add("u", 73); ht.Add("v", 79); ht.Add("w", 83); ht.Add("x", 89); ht.Add("y", 97);
            ht.Add("z", 101);

            for(int i = 0; i<word.Length;i++)
            {
                int val = (int)ht[word[i].ToString()];
                hashVal *= val;
            }
            return hashVal;
        }
    }
}
