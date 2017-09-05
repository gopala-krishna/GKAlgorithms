using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    class EvaluatePostfix
    {
        public void EvaluatePostfixExpression(string str)
        {
            StackUsingArray stack = new StackUsingArray();

            // Scan all characters one by one
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                // If the scanned character is an operand (number here),
                // push it to the stack.
                if (int.TryParse(c.ToString(),out int p))
                    stack.Push(c - '0');

                //  If the scanned character is an operator, pop two
                // elements from stack apply the operator
                else
                {
                    int val1 = stack.Pop();
                    int val2 = stack.Pop();

                    switch (c)
                    {
                        case '+':
                            stack.Push(val2 + val1);
                            break;

                        case '-':
                            stack.Push(val2 - val1);
                            break;

                        case '/':
                            stack.Push(val2 / val1);
                            break;

                        case '*':
                            stack.Push(val2 * val1);
                            break;
                    }
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
