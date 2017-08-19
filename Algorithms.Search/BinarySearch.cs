using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{

    public class BinarySearch
    {
        /// <summary>
        /// This is the recursive version of binary search
        /// Time Complexity : O(logN)
        /// Space Complexity : O(logN)
        /// </summary>
        public int BinarySearch1(int[] inputArr, int searchVal)
        {
            int minVal = 0;
            int maxVal = inputArr.Length;
           
            return BinarySearchRecursive(inputArr, searchVal, minVal, maxVal);

        }

        public int BinarySearchRecursive(int[] inputArr, int searchVal, int minVal, int maxVal)
        {
            int midVal = (minVal + maxVal) / 2;

            if (inputArr[(minVal + maxVal) / 2] == searchVal) return (minVal + maxVal) / 2;


            if (inputArr[midVal] < searchVal) return BinarySearchRecursive(inputArr, searchVal, midVal + 1, maxVal);

            if (inputArr[midVal] > searchVal) return BinarySearchRecursive(inputArr, searchVal, minVal, midVal - 1);

            return -1;
        }

        /// <summary>
        /// This is the  iterative version of binary search
        /// Time Complexity : O(logN)
        /// Space Complexity : O(1)
        /// </summary>

        public int BinarySearch2(int[] inputArr, int searchVal)
        {
            int minVal = 0;int i= 0;
            int maxVal = inputArr.Length;
            int midVal = (minVal + maxVal) / 2;

            if (searchVal == midVal)
                return midVal;


            while (i < midVal)
            {

                if(searchVal == inputArr[midVal])
                {
                    return midVal;
                }
                else if (searchVal < inputArr[midVal])
                {
                    midVal--;
                }
                else if (searchVal > inputArr[midVal])
                {
                    midVal++;
                }
            }

            return -1;
        }
    }
       
}
