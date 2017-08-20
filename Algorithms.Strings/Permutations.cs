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

        public void Permutations1(char[] set)
        {
            StringsFromCharsRecursive2(set, "", set.Length);
        }
        public void StringsFromCharsRecursive2(char[] set, string prefix, int arrSize)
        {
            if (arrSize == 0)
            {
                bool[] IsOneChar= new bool[set.Length]; bool IsFound = true;
                for (int i = 0; i < set.Length; i++)
                {
                    if(CharCount(prefix,set[i])==1)
                    {
                        IsOneChar[i] = true;
                    }
                }
                for (int i = 0; i < IsOneChar.Length; i++)
                {
                    if(IsOneChar[i] != true)
                    {
                        IsFound = false;
                    }
                }
                if (IsFound)
                    Console.WriteLine(prefix.ToString());
                return;
            }

            for (int i = 0; i < set.Length; i++)
            {

                // Next character of input added
                string newPrefix = prefix + set[i];

                // arrSize is decreased, because we have added a new character
                StringsFromCharsRecursive2(set, newPrefix, arrSize - 1);
            }
        }


        public int CharCount(string s, char c)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                { count++; }
            }
            return count;
        }



        public string[] GetPermutations(string str)
        {
            int resultLen=1;
            for(int i =1; i<= str.Length;i++)
            {
                resultLen *= i;
            }

            string[] result = new string[resultLen];

             result =Permute(str, 0, str.Length, result);

            return result;
        }
        int m = 0;
        private string[] Permute(string str, int left, int right, string []result)
        {
            if (left == right)
            {
                Console.WriteLine(str);
                result[m] = str;
                m++;
            }
            else
            {
                for (int i = left; i < right; i++)
                {
                    str = Swap(str, left, i);
                    Permute(str, left + 1, right, result);
                    str = Swap(str, left, i);
                }
            }
            return result;
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
