using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class PermutationPalindrome
    {
        public void PalindromePermutations(string str)
        {
            bool found = false;
            Permutations p = new Permutations();
            var pms = p.GetPermutations(str);
            Palindrome pa = new Palindrome();
            pa.Palindrome1(pms[9]);
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
