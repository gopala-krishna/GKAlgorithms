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
        /// </summary>
        /// <param name="arrInput"></param>
        /// <param name="arrLength"></param>
        /// <returns></returns>
        public List<BuySellInterval> BuySellPairsWithMaxProfit(long[] arrInput, long arrLength)
        {
            // Prices must be given for at least two days
            if (arrLength == 1)
                return null;
            long count = 0;

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
                bsi.Sell = i - 1;
                sol.Add(bsi);

                // Increment number of buy/sell
                count++;
            }
            return sol;
        }
    }
}
