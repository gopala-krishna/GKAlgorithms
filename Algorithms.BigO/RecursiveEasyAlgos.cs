using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BigO
{
    class RecursiveEasyAlgos
    {
        /// <summary>
        /// Expression : T(n) = 1+ T(n-1)
        /// Time Complexity O(n)
        /// </summary>
        public int Method1(int n)
        {
            if (n>1)
            return Method1(n - 1);
            return 0;
        }
    }
}
