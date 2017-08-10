using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    public class BinarySearch
    {
        public int BinarySearch1(long[] inputArr, long searchVal)
        {
            int minVal = 0;
            int maxVal = inputArr.Length;
            return BinarySearchRecursive(inputArr, searchVal, minVal, maxVal);
           
        }

        public int BinarySearchRecursive(long[] inputArr, long searchVal, int minVal, int maxVal)
        {
            int midVal = (minVal + maxVal) / 2;

            if (inputArr[midVal] == searchVal) return midVal;

            if (inputArr[midVal] < searchVal) return BinarySearchRecursive(inputArr, searchVal, midVal + 1, maxVal);

            if (inputArr[midVal] > searchVal) return BinarySearchRecursive(inputArr, searchVal, minVal, midVal + 1);

            return -1;
        }


    }
}
