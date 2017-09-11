﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{

    public class Edge
    {
        public int src, dest, weight;
        public Edge()
        {
            src = dest = weight = 0;
        }
    }

    public class Graph1
    {
        public int V, E;
        public Edge[] edge;

        // Creates a graph with V vertices and E edges
        public Graph1(int v, int e)
        {
            V = v;
            E = e;
            edge = new Edge[e];
            for (int i = 0; i < e; ++i)
                edge[i] = new Edge();
        }
    }


    public class BellamanFord
    {
        // A utility function used to print the solution
        void PrintArr(int[] dist, int V)
        {
            Console.WriteLine("Vertex   Distance from Source");
            for (int i = 0; i < V; ++i)
                Console.WriteLine(i + "                   " + dist[i]);
        }
        public void BellamanFord1(Graph1 graph, int src)
        {
            int V = graph.V, E = graph.E;
            int[] dist = new int[V];

            // Step 1: Initialize distances from src to all other
            // vertices as INFINITE
            for (int i = 0; i < V; ++i)
            {
                dist[i] = int.MaxValue;
            }

            dist[src] = 0;

            // Step 2: Relax all edges |V| - 1 times. A simple
            // shortest path from src to any other vertex can
            // have at-most |V| - 1 edges
            for (int i = 1; i < V; ++i)
            {
                for (int j = 0; j < E; ++j)
                {
                    int u = graph.edge[j].src;
                    int v = graph.edge[j].dest;
                    int weight = graph.edge[j].weight;

                    if (dist[u] != int.MaxValue && dist[u] + weight < dist[v])
                        dist[v] = dist[u] + weight;
                }
            }

            // Step 3: check for negative-weight cycles.  The above
            // step guarantees shortest distances if graph doesn't
            // contain negative weight cycle. If we get a shorter
            //  path, then there is a cycle.
            for (int j = 0; j < E; ++j)
            {
                int u = graph.edge[j].src;
                int v = graph.edge[j].dest;
                int weight = graph.edge[j].weight;

                if (dist[u] != int.MaxValue && dist[u] + weight < dist[v])
                    Console.WriteLine("Graph contains negative weight cycle");
            }
            PrintArr(dist, V);
        }
    }
}