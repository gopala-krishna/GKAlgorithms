using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Problems
{
    class StringsFromChars
    {
        /// <summary>
        /// Given a length n, count the number of strings of length n that can be made using ‘a’, ‘b’ and ‘c’ with at-most one ‘b’ and two ‘c’s allowed.
        /// </summary>
        /// <param name="n"></param>
        public void StringsFromChars1( )
        {
            char[] set = new char[] { 'a', 'b' }; int arrSize = 2;

            int charsSize = set.Length;
            StringsFromCharsRecursive(set, "",charsSize, arrSize);

        }
        public void StringsFromCharsRecursive(char[] set, string prefix, int charsSize, int arrSize)
        {
            // Base case: k is 0, print prefix
            if (arrSize == 0)
            {
                Console.WriteLine(prefix);
                return;
            }

            // call for k equals to k-1
            for (int i = 0; i < charsSize; ++i)
            {

                // Next character of input added
                String newPrefix = prefix + set[i];

                // k is decreased, because we have added a new character
                StringsFromCharsRecursive(set, newPrefix, charsSize, arrSize - 1);
            }

        }

    }
}
