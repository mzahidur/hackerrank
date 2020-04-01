using System;
using System.Collections.Generic;
using System.Linq;

namespace NearestClone
{
    class Program
    {
        static int findShortest(int graphNodes, int[] graphFrom, int[] graphTo, long[] ids, int val)
        {

            HashSet<int>[] adj = new HashSet<int>[graphNodes];
            List<int> nodesMatchingColor = new List<int>();

            for (int i = 0; i < graphNodes; i++)
            {
                adj[i] = new HashSet<int>();
                if (ids[i] == val) nodesMatchingColor.Add(i);
            }

            if (nodesMatchingColor.Count() < 2) return -1;

            for (int j = 0; j < graphFrom.Count(); j++)
            {
                var vertexOne = graphFrom[j] - 1;
                var vertexTwo = graphTo[j] - 1;
                adj[vertexOne].Add(vertexTwo);
                adj[vertexTwo].Add(vertexOne);
            }

            Queue<int> q = new Queue<int>();
            List<int> distances = new List<int>();
            List<int> visitedNodes = new List<int>();

            foreach (var startNode in nodesMatchingColor)
            {
                q.Enqueue(startNode); int counter = 0;
                while (q.Count > 0)
                {
                    var currentNode = q.Dequeue(); visitedNodes.Add(currentNode); counter++;
                    foreach (var neighbor in adj[currentNode])
                    {
                        if (ids[neighbor] == val)
                        {
                            distances.Add(counter);
                            break;
                        }
                        else
                        {
                            if (!visitedNodes.Contains(neighbor))
                                q.Enqueue(neighbor);
                        }
                    }
                }
            }
            return distances.Min();
        }



        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] graphNodesEdges = Console.ReadLine().Split(' ');
            int graphNodes = Convert.ToInt32(graphNodesEdges[0]);
            int graphEdges = Convert.ToInt32(graphNodesEdges[1]);

            int[] graphFrom = new int[graphEdges];
            int[] graphTo = new int[graphEdges];

            for (int i = 0; i < graphEdges; i++)
            {
                string[] graphFromTo = Console.ReadLine().Split(' ');
                graphFrom[i] = Convert.ToInt32(graphFromTo[0]);
                graphTo[i] = Convert.ToInt32(graphFromTo[1]);
            }
            string[] stringColorIds = Console.ReadLine().Split(' ');
            long[] colorIds = new long[graphNodes];
            for (int j = 0; j < graphNodes; j++)
            {
                colorIds[j] = Convert.ToInt32(stringColorIds[j]);
            }

            int val = Convert.ToInt32(Console.ReadLine());
            int ans = findShortest(graphNodes, graphFrom, graphTo, colorIds, val);

            Console.WriteLine(ans);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
