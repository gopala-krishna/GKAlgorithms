using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{

    public class Graph
    {
        // No. of vertices
        public int verticesCount;
        //Adjacency Lists
        public List<int>[] adjLists;

        // Constructor
        public Graph(int v)
        {
            verticesCount = v;
            adjLists = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adjLists[i] = new List<int>();
        }

        // Function to add an edge into the graph
        public void AddEdge(int vertice , int edge)
        {
            adjLists[vertice].Add(edge);
        }
    }

    public class BreadthFirstSearch
    {
        // prints BFS traversal from a given source s
        public void BreadthFirstSearch1(Graph graph, int startVertex)
        {
            
            // Mark all the vertices as not visited(By default
            // set as false)
            bool[] visited = new bool[graph.verticesCount];

            // Create a queue for BFS
            Queue<int> queue = new Queue<int>();

            // Mark the current node as visited and enqueue it
            visited[startVertex] = true;
            queue.Enqueue(startVertex);

            while (queue.Count != 0)
            {
                // Dequeue a vertex from queue and print it
                startVertex = queue.Dequeue();
                Console.WriteLine(startVertex + " ");

                // Get all adjacent vertices of the dequeued vertex s
                // If a adjacent has not been visited, then mark it
                // visited and enqueue it
                foreach (var i in graph.adjLists[startVertex])
                {
                    if (visited[i] == false)
                    {
                        visited[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }
        }
    }
}
