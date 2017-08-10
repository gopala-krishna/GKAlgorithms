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

            for (int i = 1; i < inputArr.Length; i = 2*i)
            {

                if (i >= inputArr.Length)
                {
                    maxIndex = inputArr.Length;
                    minIndex = i / 2;
                    break;
                }
                if (searchVal <= inputArr[i])
                {
                    maxIndex = i;
                    minIndex = i / 2;
                    break;
                }
            }
            BinarySearch bs = new BinarySearch();
            return bs.BinarySearchRecursive(inputArr, searchVal, minIndex, maxIndex);
        }
    }
}
