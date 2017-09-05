using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class StringCompression
    {
        /// <summary>
        /// BruteForce Method
        /// Time Complexity : O(26*N)
        /// </summary>
        /// <param name="str"></param>
        public void StringCompression1(string str)
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                int frequency = 0; ;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i]== c)
                    {
                        frequency++;
                    }
                }
                if (frequency > 0)
                {
                    Console.Write(c.ToString() + frequency);
                }
            }
        }

        /// <summary>
        /// Using Direct Access Table
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string StringCompression2(string str)
        {
            int[] intArr = new int[256];
            for(int i =0; i<str.Length;i++)
            {
                intArr[str[i]]++;
            }

            string result = string.Empty; 

            for (int i = 0; i < intArr.Length; i++)
            {
                if(intArr[i]>0)
                {
                    char c = (char)i;
                    result += c.ToString() + intArr[i].ToString();
                    //Console.Write(c); Console.Write(intArr[i]);
                }
            }

            if (result.Length < str.Length)
            {
                return result;
            }
            else
            {
                return str;
            }
        }

        /// <summary>
        /// Using Hashing
        /// Time Complexity : O(N)
        /// </summary>
        /// <param name="str"></param>
        public void StringCompression3(string str)
        {
            int[] frequency = new int[26];

            for(int i =0; i<str.Length;i++)
            {
                int index = Hash(str[i]);
                frequency[index]++;
            }

            for (int i = 0; i < 26; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.Write(((char)(i + 'a')).ToString() + frequency[i]);
                }
            }
        }
        private int Hash(char c)
        {
            return c - 'a';
        }
           
    }
}
