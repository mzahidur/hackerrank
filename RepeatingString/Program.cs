using Algorithm.Math;
using System;
using System.Collections.Generic;
namespace RepeatingString
{
    class Program
    {
        // Complete the repeatedString function below.
        static long repeatedString(string s, long modulo, out long occurance)
        {
            var foundIndexes = new List<int>();

            long t1 = DateTime.Now.Ticks;
            for (int i = s.IndexOf('a'); i > -1; i = s.IndexOf('a', i + 1))
            {
                // for loop end when i=-1 ('a' not found)
                foundIndexes.Add(i);
            }
            occurance = foundIndexes.Count;
            if (modulo == 0)
            {
                return 0;
            }
            //long wholeCount = foundIndexes.Count * ( n / s.Length);
            long wholeCount = 0;
            long last = -1;
            for (int i = 0; i < foundIndexes.Count; i++)
            {
                if (modulo < (foundIndexes[i]+1))
                {
                    break;
                }
                last = i + 1;
            }
            if (last > 0)
            {
                wholeCount += last;
            }
            
            return wholeCount;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();
            string n = Console.ReadLine();
            //long n = Convert.ToInt64(Console.ReadLine());
            long modulo = 0;
            string divResult = NumberOperations.longDivision(n, s.Length, out modulo);
            long occurances;
            long result = repeatedString(s, modulo, out occurances);
            string strRepeatCount = NumberOperations.longSum(NumberOperations.longMultiply(divResult, occurances.ToString()), result.ToString());

            Console.WriteLine(strRepeatCount);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
