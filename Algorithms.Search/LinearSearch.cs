using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    class LinearSearch
    {
        public long LinearSearch1(long[] inputArr, long searchVal)
        {
            for (long i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] == searchVal)
                    return i;
            }
            return -1;
        }
    }
}