using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class CharsIsUnique
    {
        /// <summary>
        ///  Time Complexity : O(n*n)
        ///  Space Complexity : O(1)
        /// </summary>
        public void CharsIsUnique1(string str)
        {
            bool unique = false;
            for( int i = 0; i< str.Length;i++)
            {
                for(int j = i+1; j< str.Length; j++)
                {
                    if(str[i] == str[j])
                    {
                        unique = true;
                    }
                }
            }
           

        }

        /// <summary>
        ///  Time Complexity : O(n)
        ///  Space Complexity : O(1)
        /// </summary>
        public void CharsIsUnique2(string str)
        {
            bool unique = false;

            if (str.Length > 256)
                return;
            bool[] asciiset = new bool[256];
            for (int i = 0; i < str.Length; i++)
            {

                if (asciiset[str[i]])
                {
                    unique = true;
                }
                asciiset[str[i]] = true;
            }

            if (unique)
            {
                Console.WriteLine("chars in this string are not unique");
            }
            else
            {
                Console.WriteLine("chars in this string are unique");
            }

        }
    }
}
