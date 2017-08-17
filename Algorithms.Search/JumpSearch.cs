using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    class JumpSearch
    {
        /// <summary>
        /// Time Complexity : O(√n)
        /// Auxiliary Space : O(1)
        /// </summary>
        /// <param name="inputArr"></param>
        /// <param name="searchVal"></param>
        /// <returns></returns>
        public int JumpSearch1(long[] inputArr, int searchVal)
        {
            int jumpInterval = Convert.ToInt32(Math.Sqrt(inputArr.Length)); int maxIndex =0; int minIndex =0;
            if (searchVal == inputArr[0]) return 0;

            int i = 1;

            while ( i < inputArr.Length)
            {
                if (searchVal <= inputArr[i])
                {
                    maxIndex = i;
                    minIndex = i / jumpInterval;
                    break;
                }

                if (i*jumpInterval >= inputArr.Length)
                {
                    maxIndex = inputArr.Length;
                    minIndex = i;
                    break;
                }
                else
                {
                    i = i * jumpInterval;
                }
            }

            // if(searchVal == inputArr[0]) return 0;

            //for (int i = 1; i < inputArr.Length; i=i*jumpInterval)
            //{

            //    //if (i > inputArr.Length)
            //    //{
            //    //    maxIndex = inputArr.Length;
            //    //    minIndex = i / jumpInterval;
            //    //    break;
            //    //}
            //    if (searchVal <= inputArr[i])
            //    {
            //        maxIndex = i;
            //        minIndex = i / jumpInterval;
            //        break;
            //    }
            //}
            BinarySearch bs = new BinarySearch();
            return bs.BinarySearchRecursive(inputArr, searchVal, minIndex, maxIndex);
        }
    }
}
