using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = MergeAlternately("abc", "pqr");
            Debug.Assert(result.Equals("apbqcr"));
            result = MergeAlternately("ab", "pqrs");
            Debug.Assert(result.Equals("apbqrs"));
            result = MergeAlternately("abcd", "pq");
            Debug.Assert(result.Equals("apbqcd"));
        }


        public static string MergeAlternately(string word1, string word2)
        {
            char[] word1CharArray = word1.ToCharArray();
            char[] word2CharArray = word2.ToCharArray();

            int n = word1CharArray.Length;
            if(n < word2CharArray.Length)
                n = word2CharArray.Length;

            List<char> strings = new List<char>();
            for(int i = 0; i < n; i++)
            {
                if(i < word1CharArray.Length)
                    strings.Add(word1CharArray[i]);

                if (i < word2CharArray.Length)
                    strings.Add(word2CharArray[i]);
            }


            return new string(strings.ToArray());   
        }
    }
}
