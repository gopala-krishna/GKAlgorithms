using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class Palindrome
    {
        public bool Palindrome1(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    break;
                }
                return true;
            }
            return false;
        }
    }
}
