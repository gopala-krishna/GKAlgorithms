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

        public void StringToASCII()
        {
            string s = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < s.Length; i++)
            {
                int n = s[i];

                Console.WriteLine(n);
            }

            char c = (char)103;
            Console.WriteLine(c);

        }

        public void NumberInWords(long num)
        {
            if(num>=100000000)
            {
                Console.WriteLine("please input number less than 100000000");
                return;
            }
            string sentence = string.Empty;         //53465781
            sentence += ConvertToWord((num / 10000000), "crore ");
            sentence += ConvertToWord((num/ 100000)%100, "lakh ");
            sentence += ConvertToWord((num / 1000) % 100, "thousand ");
            sentence += ConvertToWord((num / 100)%10, "hundred ");
            sentence += ConvertToWord(num % 100, " ");

            //if (num > 100 && num % 100)
            //{ 
            //   sentence += "and ";
            //}

            Console.WriteLine(sentence);

        }

        public string ConvertToWord(long n, string word)
        {
            // strings at index 0 is not used, it is to make array
            // indexing simple
            string[] one = { "", "one ", "two ", "three ", "four ",
                "five ", "six ", "seven ", "eight ",
                "nine ", "ten ", "eleven ", "twelve ",
                "thirteen ", "fourteen ", "fifteen ",
                "sixteen ", "seventeen ", "eighteen ",
                "nineteen "
            };

            // strings at index 0 and 1 are not used, they is to
            // make array indexing simple
            string[] ten = { "", "", "twenty ", "thirty ", "forty ",
                "fifty ", "sixty ", "seventy ", "eighty ",
                "ninety "
            };

            string partSentence = string.Empty;

            if(n>19)
            {
                partSentence += ten[n / 10] + one[n % 10];
            }
            else
                partSentence += one[n % 10];

            if (n>0)
                partSentence += word;

            return partSentence;
        }


        public void MetaStrings()
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

            if(found)
            {
                Console.WriteLine("they are meta strings");
            }
            else
            {
                Console.WriteLine("they are not meta strings");
            }



        }

    }
}
