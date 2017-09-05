using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    class ReverseString
    {
        public void ReverseStringUsingStack(string str)
        {
            StackUsingArray stack = new StackUsingArray();
            string result=string.Empty;

            // Push all characters of string to stack
            for (int i = 0; i < str.Length; i++)
            {
                stack.Push(str[i]);
            }

            // Pop all characters of string and put them back to str
            for (int i = 0; i < str.Length; i++)
            {
                result += (char)stack.Pop();
            }
            Console.WriteLine(result);

        }
    }
}
