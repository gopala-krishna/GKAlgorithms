using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class StringsFromChars
    {
        /// <summary>
        /// Given a length arrSize, count the number of strings of length n that can be made using characters (chatset)
        /// </summary>
        /// <param name="n"></param>
        public void StringsFromChars1(char[] set, int arrSize)
        {
            StringsFromCharsRecursive(set, "", arrSize);
        }

        public void StringsFromCharsRecursive(char[] set, string prefix, int arrSize)
        {
            // Base case: arrSize is 0, print prefix
            if (arrSize == 0)
            {
                Console.WriteLine(prefix);
                return;
            }

            // call for arrSize equals to arrSize-1
            for (int i = 0; i < set.Length; i++)
            {

                // Next character of input added
                string newPrefix = prefix + set[i];

                // arrSize is decreased, because we have added a new character
                StringsFromCharsRecursive(set, newPrefix, arrSize - 1);
            }

        }

        /// <summary>
        /// Given a length n, count the number of strings of length n that can be made using ‘a’, ‘b’ and ‘c’ with at-most one ‘b’ and two ‘c’s allowed.
        /// </summary>
        /// <param name="set"></param>
        /// <param name="prefix"></param>
        /// <param name="charsSize"></param>
        /// <param name="arrSize"></param>
        public void StringsFromChars2(char[] set, int arrSize)
        {
            StringsFromCharsRecursive2(set, "", arrSize);
        }
        public void StringsFromCharsRecursive2(char[] set, string prefix, int arrSize)
        {
            if (arrSize == 0)
            {
                if ((CharCount(prefix, 'b') < 2) && (CharCount(prefix, 'c') < 3))
                {
                    Console.WriteLine(prefix);
                }
                return;
            }

            for (int i = 0; i < set.Length; i++)
            {

                // Next character of input added
                string newPrefix = prefix + set[i];

                // arrSize is decreased, because we have added a new character
                StringsFromCharsRecursive2(set, newPrefix ,arrSize - 1);
            }
        }


        public int CharCount( string s, char c)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i]==c)
                { count++; }
            }
            return count;
        }


        /// <summary>
        /// Given a length n, count the number of strings of length less than or equal to n that can be made using ‘a’, ‘b’ and ‘c’ 
        /// </summary>
        /// <param name="set"></param>
        /// <param name="prefix"></param>
        /// <param name="charsSize"></param>
        /// <param name="arrSize"></param>

        public void StringsFromChars3(char[] charset, int arraySize)
        {
            StringsFromCharsRecursive3(charset,"", arraySize);
        }
        private void StringsFromCharsRecursive3(char[] charset, string prefix, int arrSize)
        {
            if (arrSize > 0)
            {
                string newPrefix = string.Empty;

                for (int i = 0; i < charset.Length; i++)
                {
                    newPrefix = prefix + charset[i];
                    Console.WriteLine(newPrefix.ToString());
                    StringsFromCharsRecursive3(charset, newPrefix, arrSize - 1);
                }
            }
        }


      





    }
}
