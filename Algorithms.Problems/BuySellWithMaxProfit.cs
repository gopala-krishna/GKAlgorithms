using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.Entities;

namespace Algorithms.Problems
{
    class BuySellWithMaxProfit
    {
        /// <summary>
        /// find best buying and selling days
        /// Time Complexity : O(N)
        /// </summary>
        /// <param name="arrInput"></param>
        /// <param name="arrLength"></param>
        /// <returns></returns>
        public List<BuySellInterval> BuySellPairsWithMaxProfit(long[] arrInput, long arrLength)
        {
            // Prices must be given for at least two days
            if (arrLength == 1)
                return null;

            // solution array
            List<BuySellInterval> sol = new List<BuySellInterval>();

            // Traverse through given price array
            long i = 0;
            while (i < arrLength - 1)
            {
                // Find Local Minima. Note that the limit is (n-2) as we are
                // comparing present element to the next element. 
                while ((i < arrLength - 1) && (arrInput[i + 1] <= arrInput[i]))
                    i++;

                // If we reached the end, break as no further solution possible
                if (i == arrLength - 1)
                    break;

                // Store the index of minima
                BuySellInterval bsi = new BuySellInterval();
                bsi.Buy = i++;

                // Find Local Maxima.  Note that the limit is (n-1) as we are
                // comparing to previous element
                while ((i < arrLength) && (arrInput[i] >= arrInput[i - 1]))
                    i++;

                // Store the index of maxima
                bsi.Sell = i --;
                sol.Add(bsi);
            }
            return sol;
        }

        public void EfficientBuySellPairsWithMaxProfit(int[] arrInput)
        {
            BuySellRecursive(arrInput, 0, arrInput.Length);
        }

        public void BuySellRecursive(int[] arrInput, int start, int end)
        {

            int max_diff = arrInput[start+1] - arrInput[start];
            int min_element = arrInput[start]; 

            for (int i = start; i <end; i++)
            {
                if (arrInput[i] - min_element > max_diff)
                {
                    max_diff = arrInput[i] - min_element;
                    end = i;
                }
                if (arrInput[i] < min_element)
                {
                    min_element = arrInput[i];
                    start = i;
                }
            }

            Console.WriteLine(start + "," + end);


            BuySellRecursive(arrInput, 0, start);

               
                //BuySellRecursive(arrInput, end + 1, arrInput.Length);
                
            
        }
            
    }
}
