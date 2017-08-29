using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class InsertionSort
    {
        //public int[] InsertionSort1(int[] arrNumbers, int arrLength)
        //{
        //    int i = 0, j, iIndex;

        //    while (i < arrLength)
        //    {
        //        iIndex = arrNumbers[i];
        //        j = i;
        //        while ((j > 0) && arrNumbers[j - 1] > iIndex)
        //        {
        //            arrNumbers[j] = arrNumbers[j - 1];
        //            j = j - 1;
        //        }
        //        arrNumbers[j] = iIndex;
        //        i++;
        //    }
        //    return arrNumbers;
        //}
        /// <summary>
        ///  Written by me on 12-8-2017
         // Time Complexity : O(N* N)
         // Space Complexity : O(1)
         //</summary>
         //<param name = "arrNumbers" ></ param >
         //< param name="arrLength"></param>
         //<returns></returns>
        public int[] InsertionSort2(int[] arrNumbers, int arrLength)
        {
            // 5,2,3,1,9,4  2 5 3 1 9 4     3 5 1 9 4  2 3 1 5 9 4   6 3 9 2 7 1

            int i = 0;
            while (i < arrLength)
            {
                int key = arrNumbers[i]; int k = i;
                while (k > 0)
                {
                    if (key < arrNumbers[k - 1])
                    {
                        int temp = arrNumbers[k];
                        arrNumbers[k] = arrNumbers[k - 1];
                        arrNumbers[k - 1] = temp;
                    }
                    k--;
                }
                i++;
            }
            return arrNumbers;
        }














    }
}
