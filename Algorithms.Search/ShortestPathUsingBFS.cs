using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    class ShortestPathUsingBFS
    {
        public void ShortestPathUsingBFS1(Graph graph, int startVertex, int endVertex)
        {
            // Mark all the vertices as not visited(By default
            // set as false)
            bool[] visited = new bool[graph.verticesCount];

          // Create a queue for BFS
          Queue<int> queue = new Queue<int>();



            //Mark the current node as visited and enqueue it
           visited[startVertex] = true;
            queue.Enqueue(startVertex);

            List<int> path = new List<int>();
            while (queue.Count != 0)
            {
                // Dequeue a vertex from queue and print it
                startVertex = queue.Dequeue();

                Console.WriteLine(startVertex + " ");

                //path.Add(startVertex);

                //if (startVertex == endVertex)
                //{
                //    foreach (var i in path)
                //    {
                //        Console.Write(i + "-->");
                //    }
                //    return;
                //}


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
    






















        //public Func<T, IEnumerable<T>> ShortestPathFunction<T>(Graph<T> graph, T start)
        //{
        //    var previous = new Dictionary<T, T>();

        //    var queue = new Queue<T>();
        //    queue.Enqueue(start);

        //    while (queue.Count > 0)
        //    {
        //        var vertex = queue.Dequeue();
        //        foreach (var neighbor in graph.AdjacencyList[vertex])
        //        {
        //            if (previous.ContainsKey(neighbor))
        //                continue;

        //            previous[neighbor] = vertex;
        //            queue.Enqueue(neighbor);
        //        }
        //    }

        //    Func<T, IEnumerable<T>> shortestPath = v =>
        //    {
        //        var path = new List<T> { };

        //        var current = v;
        //        while (!current.Equals(start))
        //        {
        //            path.Add(current);
        //            current = previous[current];
        //        };

        //        path.Add(start);
        //        path.Reverse();

        //        return path;
        //    };

        //    return shortestPath;
        //}
    }
}
