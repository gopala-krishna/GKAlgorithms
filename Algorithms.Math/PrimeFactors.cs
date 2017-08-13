using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Math
{
    class PrimeFactors
    {
        public void PrimeFactors1(int n)
        {

            int i = 1;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    if (IsPrime(i))
                    {
                        Console.Write(i + ",");
                    }

                    //if (n / i == i)
                    //{
                    //    if (IsPrime(i))
                    //    {
                    //        Console.Write(i + ",");
                    //    } 
                    //}
                    //else
                    //{
                    //    if (IsPrime(n/i))
                    //    {
                    //        Console.Write(i + "," +n/i +",");
                    //    }
                    //}
                }
                i++;
            }

        }

        public bool IsPrime(int num)
        {
            int i = 1; int count = 0;
            while (i <= System.Math.Sqrt(num))
            {
                if (num % i == 0)
                {
                    if (num / i == i)
                    {
                        count++;
                    }
                    else
                    {
                        count++;
                    }
                }
                i++;
            }
            if (count > 1) return false; return true;
        }

        }


    }

    

