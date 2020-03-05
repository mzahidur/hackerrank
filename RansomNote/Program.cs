using System;
using System.Collections.Generic;

namespace RansomNote
{
    class Program
    {
        static void checkMagazine(string[] magazine, string[] note)
        {
            Dictionary<string, int> sources = new Dictionary<string, int>();
            Dictionary<string, int> ransom = new Dictionary<string, int>();
                
            Array.Sort(magazine);
            Array.Sort(note);
            bool possible = true;

            foreach (string word in magazine)
            {
                if (sources.ContainsKey(word))
                {
                    ++sources[word];
                }
                else 
                {
                    sources.Add(word, 1);
                }
            }
            foreach (string word in note)
            {
                if (ransom.ContainsKey(word))
                {
                    ++ransom[word];
                }
                else
                {
                    ransom.Add(word, 1);
                }
            }
            foreach (string word in ransom.Keys)
            {
                if (!sources.ContainsKey(word))
                {
                    possible = false;
                }
                else if (sources[word] < ransom[word])
                {
                    possible = false;
                }
            }
            if (possible)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static void Main(string[] args)
        {
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            checkMagazine(magazine, note);
        }
    }
}
