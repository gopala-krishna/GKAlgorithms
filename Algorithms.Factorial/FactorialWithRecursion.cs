using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Factorial
{
    class FactorialWithRecursion
    {
        public long FactorialUsingRecursion(long iInput)
        {
            if (iInput > 2)
                iInput *= FactorialUsingRecursion(iInput - 1);
            return iInput;
        }
    }
}
