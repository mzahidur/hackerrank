using System;

namespace MinimumSwap2
{
    class Program
    {
        static void swap(int a, int b, int[] arr)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;

        }
        // Complete the minimumSwaps function below.
        static int minimumSwaps(int[] arr)
        {
            int minSwap = 0;
            bool[] swapped = new bool[arr.Length];
            if (arr.Length == 1) return 0;
            int i = 0;
            int j = 1;
            while (i < arr.Length)
            {
                if (arr[i] != (i + 1))
                {
                    minSwap++;
                    swapped[arr[i] - 1] = true;
                    swap(i, arr[i] - 1, arr);
                    if (arr[i] == (i + 1))
                    {
                        swapped[i] = true;
                    }
                }
                else if (!swapped[i])
                {
                    swapped[i] = true;
                }
                if(swapped[i])
                {
                    i++;
                }
            }
            return minSwap;

        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int res = minimumSwaps(arr);

            Console.WriteLine(res);
            //textWriter.WriteLine(res);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
