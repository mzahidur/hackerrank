using System;
using System.Linq;

namespace NewYearChaos
{
    class Program
    {
        // Complete the minimumBribes function below.
        static int minimumBribes(int[] q)
        {
            int ans = 0;
            for (int i = q.Length - 1; i >= 0; i--)
            {
                if (q[i] - (i + 1) > 2)
                {
                    return -1;
                }
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                    if (q[j] > q[i]) ans++;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            
            int t = Convert.ToInt32(Console.ReadLine());
            int minBribes = 0;
            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
                minBribes = minimumBribes(q);
                if (minBribes > -1)
                {
                    Console.WriteLine(minBribes);
                    //textWriter.WriteLine(minBribes);
                }
                else
                {
                    Console.WriteLine("Too chaotic");
                    //textWriter.WriteLine("Too chaotic");
                }
            }
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
