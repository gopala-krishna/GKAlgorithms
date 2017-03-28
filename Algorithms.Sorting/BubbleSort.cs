using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class BubbleSort
    {
        public int[] BubbleSort1(int[] arrNumbers, int arrLength)
        {
            int iTemp;                                                                                         // 5 4 3 2 1--- 4 5 3 2 1- 4 3 5 2 1- 4 3 2 5 1 - 4 3 2 1 5
                                                                                                               // 4 3 2 1 5 --- 3 4 2 1 5 - 3 2 4 1 5 - 3 2 1 4 5
            for (int i = arrLength - 1; i >= 0; i--)                                                // 3 2 1 4 5 --- 2 3 1 4 5 - 2 1 3 4 5 
            {                                                                                                      // 2 1 3 4 5 --- 1 2 3 4 5  

                for (int j = 1; j <= i; j++)
                {
                    if (arrNumbers[j - 1] > arrNumbers[j])
                    {
                        iTemp = arrNumbers[j - 1];
                        arrNumbers[j - 1] = arrNumbers[j];
                        arrNumbers[j] = iTemp;
                    }
                }
            }
            return arrNumbers;
        }
    }
}
