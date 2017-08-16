using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class Permutations
    {
        public void GetPermutationsWithRepititionOfChars(string str)
        {
            char[] charArr = new char[str.Length];

            for(int i =0; i<str.Length; i++)
            {
                charArr[i] = str[i];
            }
            //Send the arr size same as char size 
            StringsFromChars sfc = new StringsFromChars();
            sfc.StringsFromChars1(charArr, str.Length);
        }


        public void GetPermutations(string str)
        {
            Permute(str, 0, str.Length);
        }

        private void Permute(string str, int left, int right)
        {
            if (left == right)
                Console.WriteLine(str);
            else
            {
                for (int i = left; i < right; i++)
                {
                    str = Swap(str, left, i);
                    Permute(str, left + 1, right);
                    str = Swap(str, left, i);
                }
            }
        }

        public void GetPermutationsWithoutDuplicates(string str)
        {
            PermuteWithoutDuplicates(str, 0, str.Length);
        }

        string[] result = new string[128];int k = 0;
        private void PermuteWithoutDuplicates(string str, int left, int right)
        {
             bool IsFound = false;

            if (left == right)
            {
                if (result.Length > 0 && result != null)
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        if (str == result[i])
                        {
                            IsFound = true; break;
                        }
                    }
                }
               

                if (!IsFound)
                {
                    Console.WriteLine(str);
                    result[k] = str;k++;
                }
            }
            else
            {
                for (int i = left; i < right; i++)
                {
                    str = Swap(str, left, i);
                    PermuteWithoutDuplicates(str, left + 1, right);
                    str = Swap(str, left, i);
                }
            }
        }



        private string Swap(string str, int left, int right)
        { 
                char temp;
                char[] charArray = str.ToCharArray();
                temp = charArray[left] ;
                charArray[left] = charArray[right];
                charArray[right] = temp;
            return new string(charArray);
        }




    }
}
