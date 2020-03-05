using System;

namespace TwoStrings
{
    class Program
    {
        // Complete the twoStrings function below.
        static string twoStrings(string s1, string s2)
        {
            char[] arr1 = s1.ToCharArray();
            char[] arr2 = s2.ToCharArray();
            int j;
            bool substring = false;
            for (int i = 97; i < (97 + 25); i++)
            {
                if (s1.IndexOf((char)i) >= 0 && s2.IndexOf((char)i) >= 0)
                {
                    substring = true;
                    break;
                }
            }
            return substring ? "YES" : "NO";
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);

                Console.WriteLine(result);
            }

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
