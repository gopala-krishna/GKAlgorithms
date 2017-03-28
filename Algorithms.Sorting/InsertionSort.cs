using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class InsertionSort
    {
        public int[] InsertionSort1(int[] arrNumbers, int iMaxValue)
        {
            int j, iIndex;

            for (int i = 1; i < iMaxValue; i++)
            {
                iIndex = arrNumbers[i];
                j = i;
                while ((j > 0) && arrNumbers[j - 1] > iIndex)
                {
                    arrNumbers[j] = arrNumbers[j - 1];
                    j = j - 1;
                }
                arrNumbers[j] = iIndex;

            }
            return arrNumbers;
        }
    }
}
