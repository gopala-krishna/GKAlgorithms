﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Hashing
{
    class Program
    {
        class Server
        {
            public int ID { get; set; }

            public Server(int _id)
            {
                ID = _id;
            }

            public override int GetHashCode()
            {
                return ("svr_" + ID).GetHashCode();
            }
        }

        static void Main(string[] args)
        {
            List<Server> servers = new List<Server>();
            for (int i = 0; i < 1000; i++)
            {
                servers.Add(new Server(i));
            }

            ConsistentHash<Server> ch = new ConsistentHash<Server>();
            ch.Init(servers);

            int search = 100000;

            DateTime start = DateTime.Now;
            SortedList<int, int> ay1 = new SortedList<int, int>();
            for (int i = 0; i < search; i++)
            {
                int temp = ch.GetNode(i.ToString()).ID;

                ay1[i] = temp;
            }
            TimeSpan ts = DateTime.Now - start;
            Console.WriteLine(search + " each use macro seconds: " + (ts.TotalMilliseconds / search) * 1000);

            //ch.Add(new Server(1000));
            ch.Remove(servers[1]);
            SortedList<int, int> ay2 = new SortedList<int, int>();
            for (int i = 0; i < search; i++)
            {
                int temp = ch.GetNode(i.ToString()).ID;

                ay2[i] = temp;
            }

            int diff = 0;
            for (int i = 0; i < search; i++)
            {
                if (ay1[i] != ay2[i])
                {
                    diff++;
                }
            }

            Console.WriteLine("diff: " + diff);
            Console.Read();
        }

    }
}

