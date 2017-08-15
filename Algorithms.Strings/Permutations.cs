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
            Permute(str, 0, str.Length - 1);
        }

        private void Permute(string str, int left, int right)
        {
            if (left == right)
                Console.WriteLine(str);
            else
            {
                for (int i = left; i <= right; i++)
                {
                    str = Swap(str, left, i);
                    Permute(str, left + 1, right);
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
