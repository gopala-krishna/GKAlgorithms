using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class StringCompression
    {
        public string StringCompression1(string str)
        {
            int[] intArr = new int[256];
            for(int i =0; i<str.Length;i++)
            {
                intArr[str[i]]++;
            }

            string result = string.Empty; 

            for (int i = 0; i < intArr.Length; i++)
            {
                if(intArr[i]>0)
                {
                    char c = (char)i;
                    result += c.ToString() + intArr[i].ToString();
                    //Console.Write(c); Console.Write(intArr[i]);
                }
            }

            if (result.Length < str.Length)
            {
                return result;
            }
            else
            {
                return str;
            }
        }
    }
}
