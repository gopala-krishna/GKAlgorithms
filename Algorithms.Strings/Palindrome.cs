using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class Palindrome
    {
        public bool Palindrome1(string str)
        {
            bool IsPalindrome = true;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    IsPalindrome = false;break;
                }
            }
            return IsPalindrome;
        }
    }
}
