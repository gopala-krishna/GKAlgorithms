using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Math
{
    class Factors
    {
        public void PrintFactors(int n)
        {
            int i = 1;
            while( i<= System.Math.Sqrt(n))
            {
                if(n%i == 0)
                {
                    if (n/ i == i)
                    {
                        
                        Console.Write(i + "," );
                    }
                    else
                    {
                        Console.Write(i + "," + n / i + ",");
                    }
                }
                i++;
            }
        }
    }
}
