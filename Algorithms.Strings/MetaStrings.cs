using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class MetaStrings
    {
        public void MetaStrings1()
        {
            string str1 = "abcdef"; string str2 = "aecdbf"; bool found = false;

            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        for (int j = i; j < str2.Length; j++)
                        {
                            if (str1[i] == str2[j] && str1[j] == str2[i])
                            {
                                found = true;
                            }
                        }
                    }
                }
            }

            if (found)
            {
                Console.WriteLine("They are meta strings");
            }
            else
            {
                Console.WriteLine("They are not meta strings");
            }

        }
    }
}
