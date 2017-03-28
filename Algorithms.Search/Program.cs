﻿using System;
using Algorithms.Entities;

namespace Algorithms.Search
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchMaxAndMinValuesInArray smm = new SearchMaxAndMinValuesInArray();

            //var input = TakeSearchInput();
            //var output = smm.GetMaxMinUsingLinearSearch(input, input.Length);
            //ShowSearchResult(output);

            var input = TakeSearchInput();
            var output = smm.GetMaxMinUsingBinarySearch(input, 0, input.Length -1);
            ShowSearchResult(output);

            Console.Read();

        }

        #region Input and Output Funtions for Search
        private static long[] TakeSearchInput()
        {
            Console.WriteLine("Please input numbers seperated by comma");
            string numbers = Console.ReadLine();
            var arrRawInput = numbers.Split(new char[] { ',' });
            long[] arrInput = new long[arrRawInput.Length];

            if (numbers.Length > 0)
            {
                for (int i = 0; i < arrRawInput.Length; i++)
                {
                    arrInput[i] = Convert.ToInt32(arrRawInput[i]);
                }
            }
            else
            {
                Console.WriteLine("Please input numbers seperated by ", " ");
            }
            return arrInput;
        }
        private static void ShowSearchResult(MinMaxPair arrResult)
        {
            Console.Write(arrResult.MinValue.ToString() + ",");
            Console.Write(arrResult.MaxValue.ToString());
        }
        #endregion Input and Output Funtions for Search
    }
}