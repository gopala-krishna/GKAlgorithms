using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    class ExponentialSearch
    {
        public int ExponentialSearch1(int[] inputArr, int searchVal)
        {
            int maxIndex = 0; int minIndex = 0;
            if (searchVal == inputArr[0]) return 0;


            int i = 1;

            while (i < inputArr.Length)
            {
                if (searchVal <= inputArr[i])
                {
                    maxIndex = i;
                    minIndex = i / 2;
                    break;
                }

                if (i * 2 >= inputArr.Length)
                {
                    maxIndex = inputArr.Length;
                    minIndex = i;
                    break;
                }
                else
                {
                    i = i * 2;
                }
            }













            //for (int i = 1; i < inputArr.Length; i = 2*i)
            //{

            //    if (i >= inputArr.Length)
            //    {
            //        maxIndex = inputArr.Length;
            //        minIndex = i / 2;
            //        break;
            //    }
            //    if (searchVal <= inputArr[i])
            //    {
            //        maxIndex = i;
            //        minIndex = i / 2;
            //        break;
            //    }
            //}
            BinarySearch bs = new BinarySearch();
            return bs.BinarySearchRecursive(inputArr, searchVal, minIndex, maxIndex);
        }
    }
}
