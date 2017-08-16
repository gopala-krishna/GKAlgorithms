using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class StringRotation
    {
        public void AreRotaredStrings(string str1, string str2)
        {
            SearchSubString sss = new SearchSubString();
            if (sss.SearchSubString2(str1 + str1, str2))
            {
                Console.WriteLine("These are rotated strings");
            }
            else
            {
                Console.WriteLine("These are not rotated strings");
            }
        }
    }
}
