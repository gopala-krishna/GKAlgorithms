using System;
using Algorithms.Entities;
using System.Collections.Generic;


namespace Algorithms.Search
{
    class Program
    {
        static void Main(string[] args)
        {
            //var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var edges = new[]{Tuple.Create(1,2), Tuple.Create(1,3),
            //    Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
            //    Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
            //    Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

            //var graph = new Graph<int>(vertices, edges);
            //var bfs = new BreadthFirstSearch();

            //Console.WriteLine(string.Join(", ", bfs.BFS(graph, 1)));


            //var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var edges = new[]{Tuple.Create(1,2), Tuple.Create(1,3),
            //    Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
            //    Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
            //    Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

            //var graph = new Graph<int>(vertices, edges);
            //var dfs = new DepthFirstSearch();

            //Console.WriteLine(string.Join(", ", dfs.DFS(graph, 1)));


            //var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var edges = new[]{Tuple.Create(1,2), Tuple.Create(1,3),
            //    Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
            //    Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
            //    Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

            //var graph = new Graph<int>(vertices, edges);
            //var shortestPathBFS = new ShortestPathUsingBFS();

            //var startVertex = 1;
            //var shortestPath = shortestPathBFS.ShortestPathFunction(graph, startVertex);
            //foreach (var vertex in vertices)
            //    Console.WriteLine("shortest path to {0,2}: {1}",
            //            vertex, string.Join(", ", shortestPath(vertex)));


            //Graph graph = new Graph(4);

            //graph.AddEdge(0, 1);
            //graph.AddEdge(0, 2);
            //graph.AddEdge(1, 2);
            //graph.AddEdge(2, 0);
            //graph.AddEdge(2, 3);
            //graph.AddEdge(3, 3);

            //Console.WriteLine("Following is Breadth First Traversal " +
            //                   "(starting from vertex 2)");

            //BreadthFirstSearch bfs = new BreadthFirstSearch();
            //bfs.BreadthFirstSearch1(graph, 0);
            //ShortestPathUsingBFS sp = new ShortestPathUsingBFS();
            //sp.ShortestPathUsingBFS1(graph, 0, 3);

            //DepthFirstSearch dfs = new DepthFirstSearch();
            //dfs.DepthFirstSearch1(graph, 2);


            //List<List<int>> g = new List<List<int>>();
            // number of vertices
            //int v = 4;
            // g.resize(4);

            //List<int> a = new List<int>();
            //a.Add(3); a.Add(1);a.Add(2);
            //g.Add(a);

            //List<int> b = new List<int>();
            //b.Add(3); 
            //g.Add(b);

            //List<int> c  = new List<int>();
            //c.Add(0); c.Add(1);
            //g.Add(c);

            // construct a graph
            //g[0].Add(3);
            //g[0].Add(1);
            //g[0].Add(2);
            //g[1].Add(3);
            //g[2].Add(0);
            //g[2].Add(1);

            //int src = 2, dst = 3;
            //cout << "path from src " << src
            //     << " to dst " << dst << " are \n";

            //Console.Write(src + "" + dst);

            //Test t = new Test();
            // function for finding the paths
            //t.findpaths(g, src, dst);



            // int[,] graph = new int[,]{
            //                       {0, 4, 0, 0, 0, 0, 0, 8, 0},
            //                       {4, 0, 8, 0, 0, 0, 0, 11, 0},
            //                       {0, 8, 0, 7, 0, 4, 0, 0, 2},
            //                       {0, 0, 7, 0, 9, 14, 0, 0, 0},
            //                       {0, 0, 0, 9, 0, 10, 0, 0, 0},
            //                       {0, 0, 4, 14, 10, 0, 2, 0, 0},
            //                       {0, 0, 0, 0, 0, 2, 0, 1, 6},
            //                       {8, 11, 0, 0, 0, 0, 1, 0, 7},
            //                       {0, 0, 2, 0, 0, 0, 6, 7, 0}
            //                      };
            // DijsktrasShortestPathUsingAdjMatrix dsp = new DijsktrasShortestPathUsingAdjMatrix();
            //// dsp.Dijkstra(graph, 3);
            // Console.WriteLine();
            // dsp.Dijkstra(graph, 3, 8,true);

            int V = 5;  // Number of vertices in graph
            int E = 8;  // Number of edges in graph

            EdgeGraph graph = new EdgeGraph(V, E);

            // add edge 0-1 (or A-B in above figure)
            graph.edge[0].src = 0;
            graph.edge[0].dest = 1;
            graph.edge[0].weight = -1;

            // add edge 0-2 (or A-C in above figure)
            graph.edge[1].src = 0;
            graph.edge[1].dest = 2;
            graph.edge[1].weight = 4;

            // add edge 1-2 (or B-C in above figure)
            graph.edge[2].src = 1;
            graph.edge[2].dest = 2;
            graph.edge[2].weight = 3;

            // add edge 1-3 (or B-D in above figure)
            graph.edge[3].src = 1;
            graph.edge[3].dest = 3;
            graph.edge[3].weight = 2;

            // add edge 1-4 (or A-E in above figure)
            graph.edge[4].src = 1;
            graph.edge[4].dest = 4;
            graph.edge[4].weight = 2;

            // add edge 3-2 (or D-C in above figure)
            graph.edge[5].src = 3;

            graph.edge[5].dest = 2;
            graph.edge[5].weight = 5;

            // add edge 3-1 (or D-B in above figure)
            graph.edge[6].src = 3;
            graph.edge[6].dest = 1;
            graph.edge[6].weight = 1;

            // add edge 4-3 (or E-D in above figure)
            graph.edge[7].src = 4;
            graph.edge[7].dest = 3;
            graph.edge[7].weight = -3;

            BellamanFord bf = new BellamanFord();
            bf.BellamanFord1(graph, 0);
        
            Console.Read();


            //SearchMaxAndMinValuesInArray smm = new SearchMaxAndMinValuesInArray();
            //LinearSearch ls = new LinearSearch();
            //BinarySearch bs = new BinarySearch();
            //JumpSearch js = new JumpSearch();
            //ExponentialSearch es = new ExponentialSearch();
            //var input = TakeSearchInput();
            //var output = smm.GetMaxMinUsingLinearSearch(input, input.Length);
            //ShowSearchResult(output);

            //var input = TakeSearchInput();
            //var output = smm.GetMaxMinUsingBinarySearch(input, 0, input.Length -1);
            //ShowSearchResult(output);

            //var input = TakeSearchInput();
            //var output = ls.LinearSearch1(input, 12);
            //Console.WriteLine(output);
            //Console.Read();

            //var input = TakeSearchInput();
            //var output = bs.BinarySearch2(input, 12);
            //Console.WriteLine(output);
            //Console.Read();

            //var input = TakeSearchInput();
            //var output = js.JumpSearch1(input, 12);
            //Console.WriteLine(output);
            //Console.Read();

            //var input = TakeSearchInput();
            //InterpolationSearch ips = new InterpolationSearch();
            //int abc = ips.interpolationSearch1(input, 8);
            //Console.WriteLine(abc.ToString());
            //Console.Read();

            //var input = TakeSearchInput();
            //try
            //{
            //    var output = es.ExponentialSearch1(input, 12);
            //    Console.WriteLine(output);
            //    Console.Read();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

        }

        #region Input and Output Funtions for Search
        private static int[] TakeSearchInput()
        {
            Console.WriteLine("Please input numbers seperated by comma");
            string numbers = Console.ReadLine();
            var arrRawInput = numbers.Split(new char[] { ',' });
            int[] arrInput = new int[arrRawInput.Length];

            if (numbers.Length > 0)
            {
                for (int i = 0; i < arrRawInput.Length; i++)
                {
                    arrInput[i] = Convert.ToInt32(arrRawInput[i]);
                }
            }
            else
            {
                Console.WriteLine("Please input numbers seperated by ", " ");
            }
            return arrInput;
        }
        private static void ShowSearchResult(MinMaxPair arrResult)
        {
            Console.Write(arrResult.MinValue.ToString() + ",");
            Console.Write(arrResult.MaxValue.ToString());
        }
        #endregion Input and Output Funtions for Search
    }
}