using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.Entities;

namespace Algorithms.Search
{
    public class SearchMaxAndMinValuesInArray
    {
        public MinMaxPair GetMaxMinUsingLinearSearch(long[] arrInput, long arrLength)
        {
            MinMaxPair minmax = new MinMaxPair(); long i;

            /*If there is only one element then return it as min and max both*/
            if (arrLength == 1)
            {
                minmax.MaxValue = arrInput[0];
                minmax.MinValue = arrInput[0];
                return minmax;
            }

            /* If there are more than one elements, then initialize min 
                and max*/
            if (arrInput[0] > arrInput[1])
            {
                minmax.MaxValue = arrInput[0];
                minmax.MinValue = arrInput[1];
            }
            else
            {
                minmax.MaxValue = arrInput[1];
                minmax.MinValue = arrInput[0];
            }

            for (i = 2; i < arrLength; i++)
            {
                if (arrInput[i] > minmax.MaxValue)
                    minmax.MaxValue = arrInput[i];

                else if (arrInput[i] < minmax.MinValue)
                    minmax.MinValue = arrInput[i];
            }

            return minmax;

        }


        public MinMaxPair GetMaxMinUsingBinarySearch( long[] arrInput, long low, long high)
        {
            MinMaxPair minmax = new MinMaxPair();
            MinMaxPair mml = new MinMaxPair();
            MinMaxPair mmr= new MinMaxPair();
            long mid;

            /* If there is only on element */
            if (low == high)
            {
                minmax.MinValue = arrInput[low];
                minmax.MaxValue = arrInput[low];
                return minmax;
            }

            /* If there are two elements */
            if (high == low + 1)
            {
                if (arrInput[low] > arrInput[high])
                {
                    minmax.MaxValue = arrInput[low];
                    minmax.MinValue = arrInput[high];
                }
                else
                {
                    minmax.MaxValue = arrInput[high];
                    minmax.MinValue = arrInput[low];
                }
                return minmax;
            }

            /* If there are more than 2 elements */
            mid = (low + high) / 2;
            mml = GetMaxMinUsingBinarySearch(arrInput, low, mid);
            mmr = GetMaxMinUsingBinarySearch(arrInput, mid + 1, high);

            /* compare minimums of two parts*/
            if (mml.MinValue < mmr.MinValue)
                minmax.MinValue = mml.MinValue;
            else
                minmax.MinValue = mmr.MinValue;

            /* compare maximums of two parts*/
            if (mml.MaxValue > mmr.MaxValue)
                minmax.MaxValue = mml.MaxValue;
            else
                minmax.MaxValue = mmr.MaxValue;

            return minmax;

        }


    }

    
}
