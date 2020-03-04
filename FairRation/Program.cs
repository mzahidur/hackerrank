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

    // Complete the fairRations function below.
    static int fairRations(int[] B)
    {
        int[] evenOdd = new int[B.Length];
        List<int> oddIndeces = new List<int>();
        for (int i = 0; i<B.Length;i++)
        {
            evenOdd[i] = B[i] % 2 == 1 ? 1 : 0;
            if (B[i] % 2 == 1)
            {
                oddIndeces.Add(i);
            }
        }
        if (oddIndeces.Count % 2 == 1)
        {
            return -1;
        }
        int first = -1;
        int second = -1;
        int totalNumberOfBreads = 0;
        for (int i = 0; i < oddIndeces.Count; i+=2)
        {
            first = oddIndeces[i];
            second = oddIndeces[i + 1];
            totalNumberOfBreads += (second - first) * 2;
        }
        return totalNumberOfBreads;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int N = Convert.ToInt32(Console.ReadLine());

        int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp));

        int result = fairRations(B);
        if (result < 0)
        {
            Console.WriteLine("NO");
            return;
        }
        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
