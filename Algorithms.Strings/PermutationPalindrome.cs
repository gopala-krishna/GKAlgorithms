using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class PermutationPalindrome
    {
        public void IsPermutaionPalindrome(string str)
        {
            bool found = false;
            Permutations p = new Permutations();
            var pms = p.GetPermutations(str);
            Palindrome pa = new Palindrome();
            for(int i =0; i<pms.Length;i++)
            {
                if(pa.Palindrome1(pms[i]))
                {
                    Console.WriteLine(pms[i]);
                    found = true;
                }
            }
            if(!found)
            {
                Console.WriteLine("No palindromes found");
            }
        }

    }
}
