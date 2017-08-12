using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Math
{
    class Factorial
    {
        /// <summary>
        ///  Iterative Version
        /// </summary>
        /// <param name="iInput"></param>
        /// <returns></returns>
        public long FactorialUsingForLoop(long iInput)
        {
            long iResult = 1;
            for (long i = 2; i <= iInput; i++)
            {
                iResult *= i;
            }
            return iResult;
        }

        /// <summary>
        ///  Recursive Version
        /// </summary>
        /// <param name="iInput"></param>
        /// <returns></returns>
        public long FactorialUsingRecursion(long iInput)
        {
            if (iInput > 2)
                iInput *= FactorialUsingRecursion(iInput - 1);
            return iInput;
        }
    }
}
