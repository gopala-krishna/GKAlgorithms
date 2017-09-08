using System;
using Algorithms.Entities;


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


            var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var edges = new[]{Tuple.Create(1,2), Tuple.Create(1,3),
                Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

            var graph = new Graph<int>(vertices, edges);
            var shortestPathBFS = new ShortestPathUsingBFS();

            var startVertex = 1;
            var shortestPath = shortestPathBFS.ShortestPathFunction(graph, startVertex);
            foreach (var vertex in vertices)
                Console.WriteLine("shortest path to {0,2}: {1}",
                        vertex, string.Join(", ", shortestPath(vertex)));


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