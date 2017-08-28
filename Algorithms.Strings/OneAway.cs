using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class OneAway
    {
        public void IsOneAway(string str1, string str2)
        {
            int result = 0;
            if(str1.Length - str2.Length > 1)
            {
                Console.WriteLine("Not Oneaway");
            }
            int[] charset = new int[256];
            for(int i =0; i<str1.Length;i++)
            {
                charset[str1[i]]++;
            }
            for (int i = 0; i < str2.Length; i++)
            {
                charset[str2[i]]--;
            }

            for (int i = 0; i < charset.Length; i++)
            {
                result += Math.Abs(charset[i]);
            }

            if (result >2)
            {
                Console.WriteLine("Not Oneaway");
            }
            else
            {
                Console.WriteLine("Oneaway");
            }



        }
    }
}
