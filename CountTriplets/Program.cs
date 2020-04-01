using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the countTriplets function below.
    static long countTriplets(List<long> arr, long r)
    {
        long i = 0, j = 0, k = 0;
        long tripletCount = 0;
        Dictionary<long, long> hashTable = new Dictionary<long, long>();
        for (int index = 0; index < arr.Count; index++)
        {
            if (hashTable.ContainsKey(arr[index]))
            {
                hashTable[arr[index]]++;
            }
            else 
            {
                hashTable.Add(arr[index], 1);
            }
        }
        arr = arr.Distinct().ToList();
        for (int index = 0; index < arr.Count; index++)
        {
            i = (arr[index] % (r * r) == 0)? arr[index] / (r * r): 0;
            j = (arr[index] % (r) == 0) ? arr[index] / (r) : 0;
            k = arr[index];

            if (hashTable.ContainsKey(i) && hashTable.ContainsKey(j) && hashTable.ContainsKey(k))
            {

                tripletCount += (hashTable[i] * hashTable[j] * hashTable[k]);
            }
        }
        return tripletCount;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nr = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(nr[0]);

        long r = Convert.ToInt64(nr[1]);

        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        long ans = countTriplets(arr, r);

        Console.WriteLine(ans);
        //textWriter.WriteLine(ans);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
