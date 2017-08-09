using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BigO
{
    public class IterativeEasyAlgos
    {
        /// <summary>
        /// Time Complexity O(1)
        /// </summary>
        public void Method1()
        {
            Console.WriteLine("Gopala is Great");
        }

        /// <summary>
        /// Time Complexity O(n)
        /// </summary>
        public void Method2()
        {
            int n = int.MaxValue;
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("Gopala is Great");
            }
        }

        /// <summary>
        /// Time Complexity O(Squareroot n)
        /// </summary>
        public void Method3()
        {
            int n = int.MaxValue;
            for (int i = 1; i*i < n; i++)
            {
                Console.WriteLine("Gopala is Great");
            }
        }

        /// <summary>
        /// i : 1,2,4,8,16......n
        /// i : 1, 2 exp 1, 2 exp 2, 2 exp 3, 2 exp k;
        ///  2 exp k = n 
        ///  k = log n
        /// Time Complexity O(logn base 2)
        /// </summary>
        public void Method8()
        {
            int n = int.MaxValue;
            for (int i = 1; i < n; i=i*2)
            {
                Console.WriteLine("Gopala is Great");
            }
        }

        /// <summary>
        /// i : 1  j : n times
        /// i : 2  j : n/2 times
        /// i : 3  j : n/3 times
        /// i : k  j : n/k times 
        /// 
        /// Total Executed Time : n*(1+1/2+1/3+1/4......1/n)
        /// 
        /// Time Complexity O(n log n)
        /// </summary>
        public void Method11()
        {
            int n = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j = j + i)
                {
                    Console.WriteLine("Gopala is Great");
                }
            }
        }

        /// <summary>
        /// since j = 2, 2 exp k = n
        /// Time Complexity O(log n base 2)
        /// if j=m  then Time Complexity O(log n base m)
        /// </summary>
        public void Method10()
        {
            int n = int.MaxValue; int j = 2;
            while (n > 1)
            {
                n = n / j;
            }
        }

        /// <summary>
        /// Time Complexity O(n Square)
        /// </summary>
        public void Method4()
        {
            int n = int.MaxValue;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; i < n; j++)
                {
                    Console.WriteLine("Gopala is Great");
                }
            }
        }

        /// <summary>
        /// i-> 1  2  3  4  5..................k
        /// j-> 1  3  6 10 15.................n
        /// 
        /// n =(k*(k+1))/2
        /// 
        /// Time Complexity O(Sqrt n)
        /// 
        /// </summary>
        public void Method5()
        {
            int i = 1; int j = 1; int n = int.MaxValue;

            while (j <= n)
            {
                i++;
                j = j + i;
                Console.WriteLine("Gopala is Great");
            }

        }

        /// <summary>
        ///  i = 1 : j = 1 time : k = 100 times
        ///  i = 2 : j = 2 times : k = 2*100 times
        ///  i = 3 : j = 3 times : k = 3*100 times
        ///  i = 4 : j = 4 times : k = 4*100 times
        ///  i = 5 : j = 5 times : k = 5*100 times
        ///  i = n : j = n times : k = n*100 times
        ///  
        /// Total No of times : 100(1+2+3+4+5....n) = 100 * (n(n+1))/2
        /// 
        /// Time Complexity O(n Square)
        /// 
        /// </summary>
        public void Method6()
        {
             int n = int.MaxValue;

            for (int i=1; i<n; i++)
            {
                for (int j =1; j<=i; j++)
                {
                    for (int k=1; k<100; k++)
                    {
                        Console.WriteLine("Gopala is great");
                    }
                }
            }

        }

        /// <summary>
        ///  i = 1 : j = 1 time : k = n/2*1 times
        ///  i = 2 : j = 4 times : k = n/2*4 times
        ///  i = 3 : j = 9 times : k = n/2*9 times
        ///  i = n : j = n*n times : k = (n/2)*n*n times
        ///  
        /// Total No of times : n/2(1+4+9+....n*n) = (n/2)*((n)*(n+1)*(2n+1))/6
        /// 
        /// Time Complexity O(n exp 4)
        /// 
        /// </summary>
        public void Method7()
        {
            int n = int.MaxValue;

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i*i; j++)
                {
                    for (int k = 1; k < n/2; k++)
                    {
                        Console.WriteLine("Gopala is great");
                    }
                }
            }

        }


        /// <summary>
        /// First forloop executes n/2 times
        /// Second for loop executes  n/2 times
        /// Third  for loop executes logn times
        /// 
        /// Time Complexity O(n  Squree log n base 2)
        /// 
        /// </summary>
        public void Method9()
        {
            int n = int.MaxValue;

            for (int i = n/2; i < n; i++)
            {
                for (int j = 1; j <= n/2; j++)
                {
                    for (int k = 1; k < n; k=k*2)
                    {
                        Console.WriteLine("Gopala is great");
                    }
                }
            }

        }


        /// <summary>
        ///  k = 1 : n=4: j = 2,4 : executed n*2 times
        ///  k = 2 : n=16: j = 2,4,16 : executed n*3 times
        ///  k = 3 : n=256 : j = 2,4,16,256 : executed n*4 times 
        ///  Total Execution  Time : n*(k+1) where k= log log n
        ///  
        /// Time Complexity O(n  log  log n base 2) 
        /// </summary>
        public void Method12()
        {
            double k = 4;
            double n = Math.Pow(Math.Pow(2,2),k); 

            for (int i = 1; i < n; i++)
            {
                int j = 2;
                while (j <= n)
                {
                    j = j * j;
                    Console.WriteLine("Gopala is great");
                }

            }

        }








    }
}
