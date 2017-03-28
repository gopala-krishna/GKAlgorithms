using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Problems
{
    class MaxDiffWithMinbeforeMax
    {
        /// <summary>
        /// Use two loops. In the outer loop, pick elements one by one and in the inner loop calculate the difference of the
        /// picked element with every other element in the array and compare the difference with the maximum difference calculated so far.
        /// Assumptions :
        /// 1. There are atleat two elements in an array
        /// 2.The function returns a negative value if the array is sorted in decreasing order.
        /// 3. Returns 0 if elements are equal
        /// </summary>
        /// <param name="arrInput"></param>
        /// <param name="arrLength"></param>
        /// <returns></returns>
        public long SimpleWithTwoLoops(long[] arrInput, long arrLength)
        {
            long max_diff = arrInput[1] - arrInput[0];

            for (long i = 0; i < arrLength; i++)
            {
                for (long j = i + 1; j < arrLength; j++)
                {
                    if (arrInput[j] - arrInput[i] > max_diff)
                        max_diff = arrInput[j] - arrInput[i];
                }
            }
            return max_diff;
        }

        /// <summary>
        /// In this method, instead of taking difference of the picked element with every other element, we take the difference with the minimum
        /// element found so far. So we need to keep track of 2 things:
        ///  Assumptions :
        /// 1. There are atleat two elements in an array
        /// 2.The function returns a negative value if the array is sorted in decreasing order.
        /// 3. Returns 0 if elements are equal
        /// </summary>
        /// <param name="arrInput"></param>
        /// <param name="arrLength"></param>
        /// <returns></returns>
        public long EfficientWithMinValueTracking(long[] arrInput, long arrLength)
        {
            long max_diff = arrInput[1] - arrInput[0];
            long min_element = arrInput[0];

            for (long i = 1; i < arrLength; i++)
            {
                if (arrInput[i] - min_element > max_diff)
                    max_diff = arrInput[i] - min_element;
                if (arrInput[i] < min_element)
                    min_element = arrInput[i];
            }
            return max_diff;
        }
    }
}
