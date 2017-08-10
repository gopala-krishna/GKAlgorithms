using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    class ExponentialSearch
    {
        public int ExponentialSearch1(long[] inputArr, int searchVal)
        {
            int maxIndex = 0; int minIndex = 0;
            if (searchVal == inputArr[0]) return 0;

            for (int i = 1; i < inputArr.Length; i = i*2)
            {
                
                if (i > inputArr.Length) break;
                if (searchVal <= inputArr[i])
                {
                    maxIndex = i;
                    minIndex = i - Convert.ToInt32(Math.Sqrt(i));
                    break;
                }
            }
            BinarySearch bs = new BinarySearch();
            return bs.BinarySearchRecursive(inputArr, searchVal, minIndex, maxIndex);
        }
    }
}
