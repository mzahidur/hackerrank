using System;
using System.Collections.Generic;

namespace RoadsAndLibraries
{
    class Program
    {
        static Dictionary<int, HashSet<int>> Adj = new Dictionary<int, HashSet<int>>();
        static int[] Component;
        static int comp;
        static bool[] visited;
        static long roadsAndLibraries(int n, int c_lib, int c_road, int[][] cities)
        {
            if (c_road > c_lib)
                return 1L * c_lib * n;

            Adj.Clear();
            for (int i = 1; i <= n; i++)
                Adj[i] = new HashSet<int>();

            for (int i = 0; i < cities.Length; i++)
            {
                Adj[cities[i][0]].Add(cities[i][1]);
                Adj[cities[i][1]].Add(cities[i][0]);
            }

            comp = 0;
            Component = new int[n + 1];
            visited = new bool[n + 1];
            for (int i = 1; i <= n; i++)
            {
                if (!visited[i])
                {
                    DFS(i);
                    comp++;
                }
            }

            return (1L * c_road * (n - comp) + 1L * c_lib * comp);
        }

        static void DFS(int v)
        {
            visited[v] = true;
            Component[v] = comp;
            foreach (var w in Adj[v])
                if (!visited[w])
                    DFS(w);
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] nmC_libC_road = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nmC_libC_road[0]);

                int m = Convert.ToInt32(nmC_libC_road[1]);

                int c_lib = Convert.ToInt32(nmC_libC_road[2]);

                int c_road = Convert.ToInt32(nmC_libC_road[3]);

                int[][] cities = new int[m][];

                for (int i = 0; i < m; i++)
                {
                    cities[i] = Array.ConvertAll(Console.ReadLine().Split(' '), citiesTemp => Convert.ToInt32(citiesTemp));
                }

                long result = roadsAndLibraries(n, c_lib, c_road, cities);

                Console.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
