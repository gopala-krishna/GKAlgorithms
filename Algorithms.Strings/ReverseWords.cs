using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class ReverseWords
    {
        public string ReverseWordsCSharp(string str)
        {
            char[] charArray = str.ToCharArray();

            StringBuilder sb = new StringBuilder();
            List<string> words = new List<string>();

            for (int i = 0; i < charArray.Length; i++)
            {
                sb.Append(charArray[i]);
                if (charArray[i].ToString() == " " || i == charArray.Length - 1)
                {
                    words.Add(sb.ToString());
                    sb.Clear();
                }
            }
            sb.Clear();
            for (int k = words.Count; k > 0; k--)
            {
                sb.Append(words[k - 1]);
                sb.Append(" ");
            }
            return sb.ToString();
        }

        public void ReverseWords1(string str)
        {
            int k = 0; char[] word = new char[8];
            for (int i = str.Length - 1; i >= 0; i--)
            {
                word[k] = str[i];
                k++;
                if (str[i] == ' ' || i == 0)
                {
                    for (int m = word.Length - 1; m >= 0; m--)
                    {
                        Console.Write(word[m] + " ");
                    }
                    k = 0; word = new char[8];
                }
            }
        }
    }
}
