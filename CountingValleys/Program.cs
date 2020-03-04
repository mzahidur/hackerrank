using System;

namespace CountingValleys
{
    class Program
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            int seaLevel = 0;
            bool first = true;
            bool mountain = false;
            bool valley = false;
            int valleyCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (first)
                {
                    mountain =  s[i] == 'U';
                    valley = s[i] == 'D';
                    if (valley)
                    {
                        ++valleyCount;
                    }
                    first = false;
                }
                seaLevel += s[i] == 'U' ? 1 : -1;
                if (seaLevel == 0)
                {
                    first = true;
                }

            }
            return valleyCount;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            Console.WriteLine(result);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
