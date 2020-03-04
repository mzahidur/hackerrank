using System;

namespace JumpingOnClouds
{
    class Program
    {
        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {
            int numOfHops = 0;
            int span = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 0)
                {
                    span++;
                }
                else 
                {
                    //span++;
                    numOfHops += ((span + 2) / 2);
                    span = 0;
                }
                
            }
            if (span > 1)
            {
                numOfHops += (span / 2);
            }
            return numOfHops;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
