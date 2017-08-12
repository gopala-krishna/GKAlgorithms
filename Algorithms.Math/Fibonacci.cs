using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Math
{
    class Fibonacci
    {
        /// <summary>
        ///  Iteratve Fibonacci Series
        /// </summary>
        /// <param name="n"></param>

        //public void FibonacciSeriesIterative(int n)
        //{
        //    int i = 0; int j = 1; int k = 0;
        //    Console.WriteLine(i + "," + j + ",");

        //    for (int m = 2; m < n; m++)
        //    {
        //        k = i + j;
        //        Console.WriteLine(k + ",");
        //        i = j;
        //        j = k;
        //    }
        //}



        /// <summary>
        ///  nth Fibonacci number Iterative
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NthFibonacciIterative(int n)
        {
            int[] Fib = new int[n + 1];
            Fib[0] = 0; Fib[1] = 1;

            for (int i = 2; i < n; i++)
            {
                Fib[i] = Fib[i - 1] + Fib[i - 2];
            }
            return Fib[n - 1];
        }

        /// <summary>
        ///  nth Fibonacci number Recursive
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NthFibonacciRecursive(int n)
        {
            if (n == 0 || n == 1)    //1 2 3 5 8 13 21 34
            {
                return n;
            }
            else
            {
                 return NthFibonacciRecursive(n - 1) + NthFibonacciRecursive(n - 2);
            }
        }
    }
}

