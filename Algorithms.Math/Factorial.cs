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
        public int FactorialUsingForLoop(int iInput)
        {
            int iResult = 1;
            for (int i = 2; i <= iInput; i++)
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
        public int FactorialUsingRecursion(int iInput)
        {
            if (iInput > 2)
                iInput *= FactorialUsingRecursion(iInput - 1);
            return iInput;
        }

        public void DigitsCountFactorial1( int n)
        {
            int factorial = FactorialUsingRecursion(n);
            int digits = factorial.ToString().Length;
            Console.WriteLine(digits);
        }

        public void DigitsCountFactorial(int n)
        {
            if (n > 0)
            {
                double digits = 0;
                for (int i = 2; i <= n; i++)
                    digits += System.Math.Log10(i);
                Console.WriteLine((int)(System.Math.Floor(digits)) + 1);
            }
        }

    }
}
