using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class SearchSubString
    {
        public int SearchSubStringCSharp(string searchWithinThis, string searchForThis)
        {
            //string searchWithinThis = "ABCDEFGHIJKLMNOP";
            // string searchForThis = "DEF";
            int firstCharacter = searchWithinThis.IndexOf(searchForThis);
            return firstCharacter;
        }

        public void SearchSubString1()
        {
            string searchWithinThis = "ABCDEFGHIJKLMNOP";
            string word = "NiP";

            for (int i = 0; i < searchWithinThis.Length - word.Length + 1; i++)
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

        public bool SearchSubString2(string searchWithinThis, string word)
        {
            int index = 0;

            for (int i= 0; i<searchWithinThis.Length; i++)
            {
                // get index
                if (word[0] == searchWithinThis[i])
                {
                    index = i;
                    break;
                }
            }

            bool found = true;

            for (int i = 0; i < word.Length; i++)
            {
                // If word is not matched
             if (searchWithinThis[i+index] != word[i])
                {
                    found = false;
                    break;
                }
                
                // If word have been found then print found message
               
            }

            if (found)
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("not found");

            }

            return found;

        }

        public void SearchSubstring3(string str, string substr)
        {
            int[] indexArr = new int[str.Length - substr.Length]; int m = 0; bool IsSubstring = true;
            for (int i = 0; i < str.Length - substr.Length; i++)
            {
                if (str[i] == substr[0])
                {
                    indexArr[m] = i;
                }
                else
                {
                    indexArr[m] = -1;
                }
                m++;
            }
            
                for (int i = 0; i < indexArr.Length; i++)
                {
                if (indexArr[i] >= 0)
                {
                    for (int j = 0; j < substr.Length; j++)
                    {
                        if (str[indexArr[i] + j] != substr[j])
                        {
                            IsSubstring = false; break;
                        }
                    }
                }
            }
            if (IsSubstring)
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }
    }
}
