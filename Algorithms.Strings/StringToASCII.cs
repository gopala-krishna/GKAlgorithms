using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class StringToASCII
    {
        public void StringToASCII1()
        {
            string s = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < s.Length; i++)
            {
                int n = s[i];

                Console.WriteLine(n);
            }

            char c = (char)60;
            Console.WriteLine(c);

        }

    }
}
