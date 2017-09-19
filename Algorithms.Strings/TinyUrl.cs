using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace Algorithms.Strings
{
    public class TinyUrl 
    {
        public string GetShortUrl(string url)
        {
            //return String.Format("{0:X}", url.GetHashCode());

            //MD5 md5 = System.Security.Cryptography.MD5.Create();
            //SHA1 md5 = System.Security.Cryptography.SHA1.Create();
            //SHA256 md5 = System.Security.Cryptography.SHA256.Create();
            //byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(url);
            //byte[] hash = md5.ComputeHash(inputBytes);

            //Convert byte array to hex string
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < hash.Length; i++)
            //{
            //sb.Append(hash[i].ToString("x2"));
            //}
            //return sb.ToString();

            string str = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder shorturl = new StringBuilder();

            // This should be database unique id . using this for simplicity
            int n = 12345;
            //Console.WriteLine(n.ToString());

            // Convert given integer id to a base 62 number
            while (n > 0)
            {
                shorturl.Append(str[(int)n % 62]);
                n = n / 62;
            }
            // Reverse shortURL to complete base conversion
            string rstring = string.Empty;
            for (int i = shorturl.Length - 1; i >= 0; i--)
            {
                rstring += shorturl[i];
            }

            return rstring.ToString();
        }

        public int GetOriginalUrl(string tinyUrl)
        {
            int id = 0;
            for (int i = 0; i < tinyUrl.Length; i++)
            {
                if ('0' <= tinyUrl[i] && tinyUrl[i] <= '9')
                {
                    id = id * 62 + tinyUrl[i] - '0';
                }
                if ('a' <= tinyUrl[i] && tinyUrl[i] <= 'z')
                {
                    id = id * 62 + tinyUrl[i] - 'a' + 10;
                }
                if ('A' <= tinyUrl[i] && tinyUrl[i] <= 'Z')
                {
                    id = id * 62 + tinyUrl[i] - 'A' + 36;
                }
            }
            Console.WriteLine(id.ToString());
            return id;
        }

    }
}
