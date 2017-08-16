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

        public void IsPermutationPalindrome(string str)
        {
            int[] IntArr = new int[256];
            for (int i = 0; i < str.Length; i++)
            {
               IntArr[str[i]]++;
            }

            int count = 0; 
            for (int i = 0; i < IntArr.Length; i++)
            {
                if (IntArr[i] % 2 == 1)
                {
                    count++;
                }
                if(count >1)
                {
                    break;
                }
            }
            if (count < 2)
            {
                Console.WriteLine("This is a permutaion of palindrome");
            }
            else
            {
                Console.WriteLine("This is not a permutaion of palindrome");

            }

        }


        

    }
}
