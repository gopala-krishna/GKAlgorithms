using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.Sorting;

namespace Algorithms.Strings
{
    class IsPermutation
    {
        /// <summary>
        ///  Time Complexity : N * logN
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        public void IsPermutation1(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                Console.WriteLine("These strings are not permutations");return;
            }
            bool IsPermutation = true;
            int[] intS1 = new int[s1.Length];
            int[] intS2 = new int[s2.Length];

            for (int i = 0; i< s1.Length; i++)
            {
                intS1[i] = (int)s1[i];
                intS2[i] = (int)s2[i];
            }

           BubbleSort(intS1);
           BubbleSort(intS2);

            for(int i = 0; i<intS1.Length; i++)
            {
                if(intS1[i] != intS2[i])
                {
                    IsPermutation = false; break;
                }
            }

            if (IsPermutation)
            {
                Console.WriteLine("These strings are permutations");
            }
            else
            {
                Console.WriteLine("These strings are not permutations");
            }

        }

        /// <summary>
        ///  Time Complexity : O(N)
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        public void IsPermutation2(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                Console.WriteLine("These strings are not permutaions"); return;
            }
            bool IsPermutation = true;

            var letters = new int[256];
            for(int i=0; i<s1.Length;i++)
            {
                letters[s1[i]]++;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                letters[s2[i]]--;

                if (letters[s2[i]] < 0)
                {
                    IsPermutation = false;
                }
            }


            if (IsPermutation)
            {
                Console.WriteLine("These strings are permutaions");
            }
            else
            {
                Console.WriteLine("These strings are not permutaions");
            }

        }

        public static void BubbleSort(int[] arrNumbers)
        {
            int iTemp;                                                                                         // 5 4 3 2 1--- 4 5 3 2 1- 4 3 5 2 1- 4 3 2 5 1 - 4 3 2 1 5
                                                                                                               // 4 3 2 1 5 --- 3 4 2 1 5 - 3 2 4 1 5 - 3 2 1 4 5
            for (int i = arrNumbers.Length - 1; i >= 0; i--)                                                // 3 2 1 4 5 --- 2 3 1 4 5 - 2 1 3 4 5 
            {                                                                                                      // 2 1 3 4 5 --- 1 2 3 4 5  

                for (int j = 1; j <= i; j++)
                {
                    if (arrNumbers[j - 1] > arrNumbers[j])
                    {
                        iTemp = arrNumbers[j - 1];
                        arrNumbers[j - 1] = arrNumbers[j];
                        arrNumbers[j] = iTemp;
                    }
                }
            }
            //return arrNumbers;
        }
    }
}
