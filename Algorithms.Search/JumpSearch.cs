using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    class JumpSearch
    {
        public int JumpSearch1(long[] inputArr, int searchVal)
        {
            int jumpInterval = Convert.ToInt32(Math.Sqrt(inputArr.Length)); int maxIndex =0; int minIndex =0;

            for (int i = 0; i < inputArr.Length; i = i+jumpInterval)
            {
                if(searchVal <= inputArr[i])
                {
                    maxIndex = i;
                    minIndex = i - jumpInterval;
                    break;
                }
            }
            BinarySearch bs = new BinarySearch();
            return bs.BinarySearchRecursive(inputArr, searchVal, minIndex, maxIndex);
        }
    }
}
