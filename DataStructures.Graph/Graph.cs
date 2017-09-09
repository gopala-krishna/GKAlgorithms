using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
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
        public void AddEdge(int vertice, int edge)
        {
            adjLists[vertice].Add(edge);
        }
    }
}
