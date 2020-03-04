using System;

namespace FlatLand
{
    class Program
    {
        static int flatlandSpaceStations(int n, int[] c)
        {
            int mid = 0;
            int max = -1;
            int distance = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (i == 0)
                {
                    max = c[i];
                    continue;
                }
                if ((c[i] - c[i - 1]) == 1) continue;
                mid = (c[i] + c[i - 1]) / 2;
                distance = Math.Min(c[i] - mid, mid - c[i-1]);
                if (distance > max) 
                    max = distance;

            }
            if (c.Length < n) 
            {
                distance = n - c[c.Length - 1]-1;
                if (distance > max)
                    max = distance;
            }
            return max;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            Array.Sort<int>(c);
            int result = flatlandSpaceStations(n, c);

            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
