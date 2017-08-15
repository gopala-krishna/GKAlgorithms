using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class URLify
    {
        public void URLify1(char[] s, int trueLength)
        {
            //if (trueLength < s.Length)
            //    return;

            int spaceCount = 0;
            for (int i = 0; i < trueLength; i++)
            {
                if (s[i] ==' ')
                {
                    spaceCount++;
                }
            }

            int finalLen = trueLength + spaceCount * 2;

            //char[] str = new char[finalLen];

            for (int i = trueLength-1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    s[finalLen-1] = '0';
                    s[finalLen - 2] = '2';
                    s[finalLen - 1] = '%';
                    finalLen = finalLen - 3;
                }
                else
                {

                    s[finalLen - 1] = s[i];
                    finalLen--;
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
            }

        }
    }
}
