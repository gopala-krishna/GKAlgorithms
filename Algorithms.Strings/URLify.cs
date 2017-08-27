using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class URLify
    {
        /// <summary>
        /// Write a method to replace all the spaces in a string with ‘%20’.
        /// You may assume that the string has sufficient space at the end to hold the additional 
        /// characters, and that you are given the “true” length of the string.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="trueLength"></param>
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
                    s[finalLen - 3] = '%';
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
