using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class StringRotation
    {
        public void AreRotaredStrings1(string str1, string str2)
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


        public void AreRotaredStrings2(string str1, string str2)
        {
            bool IsRotation = true;
            if (str1.Length == str2.Length)
            {
                int[] charsCount = new int[256];
                for (int i = 0; i < str1.Length; i++)
                {
                    charsCount[str1[i]]++;
                }
                for (int i = 0; i < str2.Length; i++)
                {
                    charsCount[str2[i]]--;
                }

                for (int i = 0; i < charsCount.Length; i++)
                {
                    if (charsCount[i] != 0)
                    {
                        IsRotation = false; break;
                    }
                }

                Console.WriteLine(IsRotation.ToString());
            }
            else
                Console.WriteLine(IsRotation.ToString());
        }

    }
}
