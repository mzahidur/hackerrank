using System;

namespace SockMerchant
{
    class Program
    {
        static bool checkPair(int[] ar, int i)
        {
            if (i + 1 < ar.Length)
            {
                if (ar[i] == ar[i + 1])
                    return true;
            }
            return false;
        }
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            int numOfPairs = 0;
            for (int i = 0; i < n; )
            {
                if (checkPair(ar, i))
                {
                    i += 2;
                    numOfPairs++;
                }
                else 
                {
                    i++;
                }
            }
            return numOfPairs;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            Array.Sort(ar);
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
