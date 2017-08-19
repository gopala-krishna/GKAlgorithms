using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    class LinearSearch
    {
        public int LinearSearch1(int[] inputArr, int searchVal)
        {
            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] == searchVal)
                    return i;
            }
            return -1;
        }
    }
}