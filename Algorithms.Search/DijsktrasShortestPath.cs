﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    class DijsktrasShortestPath
    {
        // A utility function to find the vertex with minimum distance value,
        // from the set of vertices not yet included in shortest path tree
        static int V = 9;
        int MinDistance(int[] dist, bool[] sptSet)
        {
            // Initialize min value
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < V; v++)
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }

            return min_index;
        }

        // A utility function to print the constructed distance array
        void PrintSolution(int src, int[] dist)
        {
            for (int i = 0; i < V; i++)
                Console.WriteLine(src + " -> " +i+" "+ "Shortest distance Is"+" "+ dist[i]);
        }

        // Funtion that implements Dijkstra's single source shortest path
        // algorithm for a graph represented using adjacency matrix
        // representation
        public void Dijkstra(int[,] graph, int src)
        {
            // The output array. dist[i] will hold the shortest distance from src to i
            int[] dist = new int[V];

            // sptSet[i] will true if vertex i is included in shortest
            // path tree or shortest distance from src to i is finalized
            bool[] sptSet = new bool[V];

            // Initialize all distances as INFINITE and stpSet[] as false
            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            // Distance of source vertex from itself is always 0
            dist[src] = 0;

            // Find shortest path for all vertices
            for (int count = 0; count < V - 1; count++)
            {
                // Pick the minimum distance vertex from the set of vertices
                // not yet processed. pickedVertexIndex is always equal to src in first
                // iteration.
                int pickedVertexIndex = MinDistance(dist, sptSet);

                // Mark the picked vertex as processed
                sptSet[pickedVertexIndex] = true;

                // Update dist value of the adjacent vertices of the
                // picked vertex.
                for (int v = 0; v < V; v++)

                    // Update dist[v] only if is not in sptSet, there is an
                    // edge from u to v, and total weight of path from src to
                    // v through u is smaller than current value of dist[v]
                    if (sptSet[v] == false && graph[pickedVertexIndex, v] != 0 && dist[pickedVertexIndex] != int.MaxValue && dist[pickedVertexIndex] + graph[pickedVertexIndex, v] < dist[v])
                    {
                        dist[v] = dist[pickedVertexIndex] + graph[pickedVertexIndex, v];
                    }
            }

            // print the constructed distance array
            PrintSolution(src, dist);
        }

    }
}
