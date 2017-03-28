using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class ShellSort
    {
        public int[] ShellSort1(int[] arrNumbers, int iMaxValue)
        {
            int i, j, iIndex;
            int iIncrement = 3;

            while (iIncrement > 0)
            {

                for (i = 1; i < iMaxValue; i++)
                {
                    iIndex = arrNumbers[i];
                    j = i;
                    while ((j >= iIncrement) && arrNumbers[j - iIncrement] > iIndex)
                    {
                        arrNumbers[j] = arrNumbers[j - iIncrement];
                        j = j - iIncrement;
                    }
                    arrNumbers[j] = iIndex;

                }
                if ((iIncrement / 2) != 0)
                    iIncrement = iIncrement / 2;
                else if (iIncrement == 1)
                    iIncrement = 0;

                else
                    iIncrement = 1;
            }
            return arrNumbers;
        }

    }
}
