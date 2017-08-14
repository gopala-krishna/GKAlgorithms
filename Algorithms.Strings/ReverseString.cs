using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    class ReverseString
    {
        public string ReverseString1(string sInstring)
        {
            string sOutstring = string.Empty;
            for (int i = sInstring.Length - 1; i >= 0; i--)
            {
                sOutstring += sInstring[i];
            }
            return sOutstring;
        }

        // This is not working as the looping is reverse...which is a flaw in parallel extensions library
        public string ParallelReverseString(string sInstring)
        {
            string sOutparstring = string.Empty;
            Parallel.For(sInstring.Length - 1, 0, i =>
            {
                sOutparstring += sInstring[i];
            });
            return sOutparstring;
        }

    }
}
