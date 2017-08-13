using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Problems
{
    class MinimumSquares
    {
        public void MinimumSquares1(long a, long b)
        {
            long result = 0; long rem = 0;

            // swap if a is small size side .
            if (a < b)
            {
                long t = a;
                a = b;
                b = t;
            }

            // Iterate until small size side is greater then 0
            while (b > 0)
            {
                // Update result
                result += a / b;

                rem = a % b;
                a = b;
                b = rem;
            }
            Console.WriteLine(result);
        }
    }
}
