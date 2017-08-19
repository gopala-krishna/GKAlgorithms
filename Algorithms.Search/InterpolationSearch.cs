using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    /// <summary>
    /// Works for sorted array of n uniformly distributed values
    /// Time Complexity : O(loglog(N) can go upto O(N)
    /// Space Complexity : O(1)
    /// </summary>
    class InterpolationSearch
    {
        public int interpolationSearch1(int[] arr,  int x)
        {
            // Find indexes of two corners
            int lo = 0; int hi = arr.Length - 1;

            // Since array is sorted, an element present
            // in array must be in range defined by corner
            while (lo <= hi && x >= arr[lo] && x <= arr[hi])
            {
                // Probing the position with keeping
                // uniform distribution in mind.
                int pos = lo + (((hi - lo) /(arr[hi] - arr[lo])) * (x - arr[lo]));

                // Condition of target found
                if (arr[pos] == x)
                    return pos; 

                // If x is larger, x is in upper part
                if (arr[pos] < x)
                    lo = pos++;

                // If x is smaller, x is in lower part
                else
                    hi = pos--;
            }
            return -1;
        }
    }
}
