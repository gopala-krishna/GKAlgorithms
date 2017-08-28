using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Math
{
    class Magicumbers
    {
        public void MagicNumbers(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (i == GetFactorsSum(i))
                {
                    Console.WriteLine(i + ",");
                }
            }
        }

        public int GetFactorsSum(int num)
        {
            int i = 1; int sum = 0;

            while (i <= System.Math.Sqrt(num))
            {
                if (num % i == 0)
                {
                    if (num / i == i)
                    {
                        sum += i;
                    }
                    else
                    {
                        sum += i + num / i;
                    }
                }
                i++;
            }
         return sum-num;
        }

    }
}
