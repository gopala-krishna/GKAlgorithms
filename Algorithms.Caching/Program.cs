using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Caching
{
    class Program
    {
        static void Main(string[] args)
        {
            LazyCaching lc = new LazyCaching();
            lc.LazyCaching1();

            Console.WriteLine();

            EagerCaching ec = new EagerCaching();
            ec.EagerCaching1();
            Console.Read();

            Console.Read();
        }
    }
}
