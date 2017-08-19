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
        ///  Iterative Fibonacci Series
        /// </summary>
        /// <param name="n"></param>

        public void FibonacciSeriesIterative(int n)
        {
            int i = 0; int j = 1; int k = 0;

            for (int m = 2; m < n; m++)
            {
                k = i + j;
                Console.Write(k + ",");
                i = j;
                j = k;
            }
        }

        /// <summary>
        ///  Recursive Fibonacci Series
        /// </summary>
        /// <param name="n"></param>
        public void FibonacciSeriesRecursive(int n)
        {
            FibonacciRecursive(0, 1, 1, n);
        }

        public void FibonacciRecursive(int a, int b, int counter, int n)
        {
            if (counter <= n)
            {
                Console.Write(a + ",");
                FibonacciRecursive(b, a + b, counter+1, n);
            }
        }
        /// <summary>
        /// Find  nth Fibonacci number Iterative
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NthFibonacciIterative(int n)
        {
            int[] Fib = new int[n + 1];
            Fib[0] = 1; Fib[1] = 2;

            for (int i = 2; i < n; i++)
            {
                Fib[i] = Fib[i - 1] + Fib[i - 2];
            }
            return Fib[n-1];
        }

        /// <summary>
        /// Find  nth Fibonacci number Recursive
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NthFibonacciRecursive(int n)
        {
            if (n<=1)    //1 2 3 5 8 13 21 34
            {
                return n;
            }
            else
            {
                 return NthFibonacciRecursive(n - 1) + NthFibonacciRecursive(n - 2);
            }
        }

        public int NthFibonacciMemotized(int n)
        {
            int[] cache = new int[100];

            if (n <= 1)    //1 2 3 5 8 13 21 34
            {
                cache[n] = n;
            }
            else
            {
                cache[n] = NthFibonacciMemotized(n - 1) + NthFibonacciMemotized(n - 2);
            }
            return cache[n];
        }

        public int NthFibonacciMemotizedIterative(int n)
        {
            int[] fib = new int[n + 1];

            /* 0th and 1st number of the series are 0 and 1*/
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                /* Add the previous 2 numbers in the series
                   and store it */
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            return fib[n];
        }

    }
}

