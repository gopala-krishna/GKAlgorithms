﻿using System;

namespace Algorithms.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            TinyUrl turl = new TinyUrl();
            string tinyurl = turl.GetShortUrl("https://tblogs.msdn.microsoft.com/csharpfaq/2006/10/09/how-do-i-calculate-a-md5-hash-from-a-string");
            turl.GetOriginalUrl(tinyurl);
            //turl.GetOriginalUrl("hnd");

            //StringCompression sc = new StringCompression();
            //sc.StringCompression3("aaabbccccc");

            //StringRotation sr = new StringRotation();
            //sr.AreRotaredStrings("water", "terwa");
            //Console.Read();

            //StringsFromChars sc = new StringsFromChars();
            // char[] charset = new char[] { 'a', 'b','c' };
            //int arraySize = 3;
            //sc.StringsFromChars4(charset, "",arraySize);
            //Console.Read();

            //Permutations P = new Permutations();
            // P.GetPermutationsWithoutDuplicates("abcc");
            //Console.Read();

            //P.GetPermutationsWithRepititionOfChars("abc");

            //StringToASCII sc = new StringToASCII();
            //sc.StringToASCII2("abcdefg");

            //IsPermutation ip = new IsPermutation();
            //ip.IsPermutation1("gopala", "gbplaa");

            //string[] strArr = new string[] { "Gopala", "Krishna", "Rao" };
            //ReverseWords rw = new ReverseWords();
            //rw.ReverseWords2(strArr);

            //ReverseString rs = new ReverseString();
            // rs.ReverseString2("Gopala");

            //PermutationPalindrome p = new PermutationPalindrome();
            //p.IsPermutationPalindrome("gopgap");

            //StringRotation sr = new StringRotation();
            //sr.StringRotation123("Gopala", "palaGa");

            //SearchSubString ss = new SearchSubString();
            //ss.SearchSubstring3("abcabcdgb", "abc");

            //CharsIsUnique ciu = new CharsIsUnique();
            //ciu.CharsIsUnique2("abcca");

            //OneAway oa = new OneAway();
            //oa.IsOneAway("abk", "nbe");


            Console.Read();
        }
    }
}