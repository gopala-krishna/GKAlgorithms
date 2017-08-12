using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Algorithms.Strings
{
    class StringAlgos
    {
        public  string ReverseString(string sInstring)
        {
            string sOutstring = string.Empty;
            for (int i = sInstring.Length - 1; i >= 0; i--)
            {
                sOutstring += sInstring[i];
            }
            return sOutstring;
        }

        // This is not working as the looping is reverse...which is a flaw in parallel extensions library
        public  string ParallelReverseString(string sInstring)
        {
            string sOutparstring = string.Empty;
            Parallel.For(sInstring.Length - 1, 0, i =>
            {
                sOutparstring += sInstring[i];
            });
            return sOutparstring;
        }

        public string ReverseWordsCSharp(string str)
        {
            char[] charArray = str.ToCharArray();

            StringBuilder sb = new StringBuilder();
            List<string> words = new List<string>();

            for (int i = 0; i < charArray.Length; i++)
            {
                sb.Append(charArray[i]);
                if (charArray[i].ToString() == " " || i== charArray.Length - 1)
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

        public void ReverseWords(string str)
        {
            int k = 0; char[] word = new char[8];
            for (int i = str.Length -1; i >= 0; i--)
            {
                    word[k] = str[i];
                    k++;
                    if (str[i] == ' ' || i == 0)
                    {
                        for (int m = word.Length -1; m >= 0; m--)
                        {
                            Console.Write(word[m] +" ");
                        }
                    k = 0; word = new char[8];
                }
            }
        }

        public  int SearchSubStringCSharp(string searchWithinThis, string searchForThis)
        {
            //string searchWithinThis = "ABCDEFGHIJKLMNOP";
           // string searchForThis = "DEF";
            int firstCharacter = searchWithinThis.IndexOf(searchForThis);
            return firstCharacter;
        }

        public void SearchSubString()
        {
             string searchWithinThis = "ABCDEFGHIJKLMNOP";
             string word = "NiP";

            

            for (int i = 0; i < searchWithinThis.Length - word.Length+1; i++)
            {
                // Match word at current position
                int found = 1;
                for (int j = 0; j < word.Length; j++)
                {
                    
                    // If word is not matched
                    if (searchWithinThis[i + j] != word[j])
                    {
                        found = 0;
                        break;
                    }
                }
                // If word have been found then print found message
                if (found == 1)
                {
                    Console.WriteLine("found");
                }
            }
          
        }

        public bool Palindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    break;
                }
                return true;
            }
            return false;
        }



    }
}
