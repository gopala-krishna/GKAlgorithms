using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Factorial
{
    class FactorialWithForLoop
    {
        public long FactorialUsingForLoop(long iInput)
        {
            long iResult = 1;
            for (long i = 2; i <= iInput; i++)
            {
                iResult *= i;
            }
            return iResult;
        }
    }
}
