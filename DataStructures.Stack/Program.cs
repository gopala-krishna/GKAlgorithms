﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackUsingArray sua = new StackUsingArray();

            sua.Push(10);
            sua.Push(20);
            sua.Push(30);
            sua.Push(40);

            sua.Pop();
            sua.Pop();

            Console.WriteLine(sua.Peek());
            Console.WriteLine(sua.Count());


            //StackUsingLinkedList sull = new StackUsingLinkedList();

            //sull.Push(10);
            //sull.Push(20);
            //sull.Push(30);
            //sull.Push(40);

            //sull.Pop();

            //Console.WriteLine(sull.Peek());


            //ReverseString rs = new ReverseString();
            //rs.ReverseStringUsingStack("Gopala");

            //EvaluatePostfix ep = new EvaluatePostfix();
            //ep.EvaluatePostfixExpression("231*+9-");


            Console.Read();
        }
    }
}
