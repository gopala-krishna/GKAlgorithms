using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    class Test
    {
        // the found path in graph
        void printpath(List<int> path)
        {
            for (int i = 0; i < path.Count; i++)
                Console.WriteLine(path[i]);
        }

        // utility function to check if current
        // vertex is already present in path
        int isNotVisited(int x, List<int> path)
        {
            for (int i = 0; i < path.Count; i++)
                if (path[i] == x)
                    return 0;
            return 1;
        }

        // utility function for finding paths in graph
        // from source to destination
       public void findpaths(List<List<int>> g, int src,
                                         int dst)
        {
            // create a queue which stores
            // the paths
            Queue<List<int>> q = new Queue<List<int>>();

            // path vector to store the current path
            List<int> path = new List<int>();
            path.Add(src);
            q.Enqueue(path);
            while (q.Count != 0)
            {
                path = q.Peek();
                q.Dequeue();
                int last = path[path.Count - 1];

                // if last vertex is the desired destination
                // then print the path
                if (last == dst)
                    printpath(path);

                // traverse to all the nodes connected to 
                // current vertex and push new path to queue
                for (int i = 0; i < g[last].Count; i++)
                {
                    if (isNotVisited(g[last][i], path) ==1)
                    {
                        List<int> newpath = new List<int>();
                        newpath.Add(g[last][i]);
                        q.Enqueue(newpath);
                    }
                }
            }
        }

    }
}
