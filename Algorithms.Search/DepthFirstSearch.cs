using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
   
        //    public HashSet<T> DFS<T>(Graph<T> graph, T start)
        //    {
        //        var visited = new HashSet<T>();

        //        if (!graph.AdjacencyList.ContainsKey(start))
        //            return visited;

        //        var stack = new Stack<T>();
        //        stack.Push(start);

        //        while (stack.Count > 0)
        //        {
        //            var vertex = stack.Pop();

        //            if (visited.Contains(vertex))
        //                continue;

        //            visited.Add(vertex);

        //            foreach (var neighbor in graph.AdjacencyList[vertex])
        //                if (!visited.Contains(neighbor))
        //                    stack.Push(neighbor);
        //        }
        //        return visited;
        //    }
        //}



        public class DepthFirstSearch
        {
                       // The function to do DFS traversal. It uses recursive DFSUtil()
            public void DepthFirstSearch1(Graph graph, int startIndex)
            {
                // Mark all the vertices as not visited(set as
                // false by default in java)
                bool[] visited = new bool[graph.verticesCount];

            // Call the recursive helper function to print DFS traversal
            // starting from all vertices one by one
            //for (int i = 0; i < graph.verticesCount; ++i)
            //    if (visited[i] == false)
            //        DFSUtil(graph, i, visited);

              DFSUtil(graph, startIndex, visited);
            }

            // A function used by DFS
            public void DFSUtil(Graph graph, int startIndex, bool[] visited)
            {
                // Mark the current node as visited and print it
                visited[startIndex] = true;
                Console.WriteLine(startIndex + " ");

                // Recur for all the vertices adjacent to this vertex
                foreach (var i in graph.adjLists[startIndex])
                {
                    if (!visited[i])
                        DFSUtil(graph, i, visited);
                }
            }




        //public void DepthFirstSearch2(Graph graph, int startVertex)  /// Not working
        //{

        //    // Mark all the vertices as not visited(By default
        //    // set as false)
        //    bool[] visited = new bool[graph.verticesCount];

        //    // Create a queue for BFS
        //     Stack<int> stack = new Stack<int>();

        //    // Mark the current node as visited and enqueue it
        //    visited[startVertex] = true;
        //    stack.Push(startVertex);

        //    while (stack.Count != 0)
        //    {
        //        // Dequeue a vertex from queue and print it
        //        startVertex = stack.Pop();
        //        Console.WriteLine(startVertex + " ");

        //        // Get all adjacent vertices of the dequeued vertex s
        //        // If a adjacent has not been visited, then mark it
        //        // visited and enqueue it
        //        foreach (var i in graph.adjLists[startVertex])
        //        {
        //            if (visited[i] == false)
        //            {
        //                visited[i] = true;
        //                stack.Push(i);
        //            }
        //        }
        //    }
        //}

    }



}
