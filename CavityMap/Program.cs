using System;
using System.Linq;
using System.Text;

namespace CavityMap
{
    class Program
    {
        // Complete the cavityMap function below.
        static string[] cavityMap(string[] grid)
        {
            string[] clone = new string[grid.Length];
            grid.CopyTo(clone,0);
            for (int i = 1; i < grid.Length - 1; i++)
            {
                for (int j = 1; j < grid.Length - 1; j++)
                {
                    if (
                        grid[i][j] > grid[i - 1][j]
                        &&
                        grid[i][j] > grid[i + 1][j]
                        &&
                        grid[i][j] > grid[i][j-1]
                        &&
                        grid[i][j] > grid[i][j+1]
                        )
                    {
                        StringBuilder sb = new StringBuilder(clone[i]);
                        sb[j] = 'X';
                        clone[i] = sb.ToString();
                    }
                }
            }
            return clone;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            //string[] grid = new string[n];
            string[] grid = new string[n];

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid[i] = gridItem;
            }

            string[] result = cavityMap(grid);
            Console.WriteLine(string.Join("\n", result));
            //textWriter.WriteLine(string.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
